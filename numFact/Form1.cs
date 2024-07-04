using numFact.dao;
using numFact.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numFact
{
    public partial class Form1 : Form
    {
        private PixelDao pixelDAO;

        public Boolean SeguirProcesandoVentas;



        public Form1()
        {
            InitializeComponent();
            pixelDAO = new PixelDao();
            ConfigureDataGridView();
            InitializeDatabaseConnection();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonIniciarDia_Click(object sender, EventArgs e)
        {
            using (Procesando dialogo = new Procesando(() => IniciarDia()))
            {
                dialogo.ShowDialog();
            }
        }

        private void IniciarDia()
        {
            try
            {
                pixelDAO.EjecutarProcesoInicial();
                this.Invoke(new Action(() => { MessageBox.Show(this, "Proceso completado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information); }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => { MessageBox.Show(this, "Se produjo un error en el procesamiento inicial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                Console.WriteLine(ex);
                throw ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MostrarCargando()
        {
            //Thread hilo = new Thread(() => { new Procesando().Show(); });
            //hilo.Start();
        }

        private void CargarColumnasVentas()
        {
            dataGridViewVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVentas.Columns.Add("UId", "Código");
            dataGridViewVentas.Columns.Add("OPENDATE", "Día de Venta");
            dataGridViewVentas.Columns[0].Width = 110;
            dataGridViewVentas.Columns[1].Width = 110;
        }

        private void CargarColumnasFE()
        {
            dataGridViewFE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFE.Columns.Add("UId", "Código");
            dataGridViewFE.Columns.Add("OPENDATE", "Día de Venta");
            dataGridViewFE.Columns.Add("TOTAL", "Total");
            dataGridViewFE.Columns[0].Width = 60;
            dataGridViewFE.Columns[1].Width = 100;
            dataGridViewFE.Columns[2].Width = 50;

        }


        public void CargarVentasPendientes()
        {
            try
            {
                List<Venta> ventas = pixelDAO.VentasFindAllPendientes();
                dataGridViewVentas.Rows.Clear();
                foreach (Venta venta in ventas)
                {
                    dataGridViewVentas.Rows.Add(venta.UId, venta.OPENDATE);
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => { MessageBox.Show(this, "Se produjo un error cargando listado de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                Console.WriteLine(ex);
            }
        }

        private void CargarDocumentosPendientes()
        {
            try
            {
                List<Documento> documentos = pixelDAO.DocumentosFindAllPendientes();
                dataGridViewFE.Rows.Clear();
                foreach (Documento documento in documentos)
                {
                    dataGridViewFE.Rows.Add(documento.UId, documento.OPENDATE, documento.TOTAL);
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => { MessageBox.Show(this, "Se produjo un error cargando listado de documentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                Console.WriteLine(ex);
            }
        }

        void ProcesarVentas()
        {
            try
            {
                if (dataGridViewVentas.SelectedRows.Count <= 0)
                {
                    throw new Exception("seleccione el día de venta");
                }
                pixelDAO.EjecutarProcesoVentas(dataGridViewVentas.CurrentRow.Cells[0].Value.ToString());
                this.Invoke(new Action(() => { CargarVentasPendientes(); }));
                this.Invoke(new Action(() => { MessageBox.Show(this, "Proceso completado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information); }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => { MessageBox.Show(this, "Se produjo un error procesando ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                Console.WriteLine(ex);
                //throw ex;
            }
        }

        private void buttonProcesarVentas_Click(object sender, EventArgs e)
        {
            AsignarDescuentosSiHay();
            if (SeguirProcesandoVentas)
            {
                EnviarVentas();
            }
        }

        private void EnviarVentas()
        {
            using (Procesando proc = new Procesando(() => { ProcesarVentas(); }))
            {
                proc.ShowDialog();
            }
        }

        ///--RG

        private void AsignarDescuentosSiHay()
        {
            SeguirProcesandoVentas = false;

            //// Verificar si el dataGridView1 canales está vacío
            //if (dataGridView1.Rows.Count == 0)
            //{
            //    MessageBox.Show("No hay datos en la tabla de canales ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            // Verificar si hay alguna fila seleccionada en dataGridViewVentas
            if (dataGridViewVentas.SelectedRows.Count <= 0)
            {
                throw new Exception("Seleccione el día de venta");
            }

            // Obtener el id de la tabla para proceso de ventas
            String idTabla = dataGridViewVentas.CurrentRow.Cells[0].Value.ToString();

            // Obtener el descuento global desde los totales calculados
            Decimal valorTotalDescuento = pixelDAO.DescuentoFaltanteGetTotal(idTabla);

            // Si el total de descuento es mayor a 0, proceder con la asignación de descuentos
            if (valorTotalDescuento > new Decimal(0.01))
            {
                AsignacionDescuento asignacionDescuento = new AsignacionDescuento(idTabla, valorTotalDescuento);
                asignacionDescuento.ShowDialog(this);
            }
            else
            {
                SeguirProcesandoVentas = true;
            }
        }



        private void buttonProcesarFacturasElectronicas_Click(object sender, EventArgs e)
        {
            using (Procesando proc = new Procesando(() => { ProcesarFE(); }))
            {
                proc.ShowDialog();
            }
        }

        private void ProcesarFE()
        {
            try
            {
                if (dataGridViewFE.SelectedRows.Count <= 0)
                {
                    throw new Exception("seleccione el día de venta");
                }
                pixelDAO.EjecutarProcesoFE(dataGridViewFE.CurrentRow.Cells[0].Value.ToString(), null);
                this.Invoke(new Action(() => { CargarDocumentosPendientes(); }));
                this.Invoke(new Action(() => { MessageBox.Show(this, "Proceso completado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information); }));

            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => { MessageBox.Show(this, "Se produjo un error procesando facturación electrónica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                Console.WriteLine(ex);
                //throw ex;
            }
        }

        private void buttonProvisional_Click(object sender, EventArgs e)
        {
            try
            {
                //pixelDAO.ProvisionalEjecutarProcesoFE();
                MessageBox.Show("correcto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                panelOculto.Visible = Boolean.Parse(ConfigurationManager.AppSettings["MostrarPanelOculto"].ToString());
                pixelDAO.EjecutarCorreccionCCDomicilio();
                MostrarCargando();
                CargarColumnasVentas();
                CargarColumnasFE();
                CargarVentasPendientes();
                CargarDocumentosPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonProcesarTransaccionFE_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTransaccionCodigo.Text.Length <= 0)
                {
                    throw new Exception("ingrese el número de transacción");
                }
                if (!pixelDAO.ComprobarSiTransaccionExiste(textBoxTransaccionCodigo.Text))
                {
                    throw new Exception("El número de transacción ingresado, no existe en la base de datos");
                }
                pixelDAO.EjecutarProcesoFE(null, textBoxTransaccionCodigo.Text);
                this.Invoke(new Action(() => { MessageBox.Show(this, "Proceso completado con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information); }));

            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => { MessageBox.Show(this, "Se produjo un error procesando facturación electrónica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }));
                Console.WriteLine(ex);
                //throw ex;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                pixelDAO.Prueba();
                MessageBox.Show("CORRECTO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DataGridViewRow nuevaFila = new DataGridViewRow();
            //nuevaFila.CreateCells(dataGridView1);

            //dataGridView1.Rows.Add(nuevaFila);

    
            int rowIndex = dataGridView1.Rows.Add();

            DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            comboBoxCell.Items.AddRange("UBER", "PEYA", "RAPPI", "SUPER EASY", "CANALES PROPIOS");

            newRow.Cells[0] = comboBoxCell;


        }

        private void ConfigureDataGridView()
        {
          
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) // Verificar que no sea la fila de nueva entrada
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void InitializeDatabaseConnection()
        {
            // Inicializar la conexión a la base de datos
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            var conBI = new OdbcConnection();
            // OdbcTransaction tranBI = conBI.BeginTransaction();
            try
            {
                pixelDAO.guardarPlataformas(dataGridView1, dataGridViewVentas);
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos: " + ex.Message);
            }


        }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnProcesarPlataformas_Click(object sender, EventArgs e)
        {
            // Verificar si hay filas con datos en el DataGridView1
            bool hayDatos = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString())))
                {
                    hayDatos = true;
                    break;
                }
            }

            // Mostrar mensaje si no hay datos para guardar
            if (!hayDatos)
            {
                MessageBox.Show("No hay datos para grabar.");
                return;
            }

            var conBI = new OdbcConnection();
            // OdbcTransaction tranBI = conBI.BeginTransaction();
            try
            {
                pixelDAO.guardarPlataformas(dataGridView1, dataGridViewVentas);
                // dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos: " + ex.Message);
            }
        }

    }

}
