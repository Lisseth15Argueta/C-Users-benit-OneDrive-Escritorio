using Tarea2.ProgramacionOrientadaEventos.Laboratorio2.Tarea2;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        private List<Electrodomestico> electrodomesticos;
        private List<Cliente> clientes;
        private List<Venta> ventas;

        public Form1()
        {
            InitializeComponent();

            electrodomesticos = new List<Electrodomestico>();
            clientes = new List<Cliente>();
            ventas = new List<Venta>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarElectrodomesticos();
            CargarClientes();
            CargarVentas();
        }
        private void CargarElectrodomesticos()
        {
            ListElectrodomestico.Items.Clear();

            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                ListElectrodomestico.Items.Add(electrodomestico.ToString());
            }
        }
        private void CargarClientes()
        {
            ListClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                ListClientes.Items.Add(cliente.ToString());
            }
        }
        private void CargarVentas()
        {
            ListVentas.Items.Clear();
            foreach (Venta venta in ventas)
            {
                ListVentas.Items.Add(((Venta)venta).ToString());
            }
        }
        

        private void electrodomesticoLabel_StyleChanged(object sender, EventArgs e)
        {
            if (ListElectrodomestico.SelectedIndex!=-1) 
            electrodomesticoLabel.Text = (string)ListElectrodomestico.Items[ListElectrodomestico.SelectedIndex];

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int indice = ListElectrodomestico.SelectedIndex;

            if(indice == -1)
            {
                ListElectrodomestico.Items.RemoveAt(indice);
            }
        }

        private void electrodometicoLabel_StyleChanged(object sender, EventArgs e)
        {
            if (ListElectrodomestico.SelectedIndex != -1)
                electrodomesticoLabel.Text = (string)ListElectrodomestico.Items[ListElectrodomestico.SelectedIndex];
        }

        private void AgregarElectrodomesticoButton_Click(object sender, EventArgs e)
        {
            Electrodomestico electrodomestico = new Electrodomestico(textBoxNombreElectrodomestico.Text, int.Parse(textBoxPrecioElectrodomestico.Text));

            electrodomestico.Add(electrodomestico);
            CargarElectrodomesticos();
            textBoxNombreElectrodomestico.Text = String.Empty;
            textBoxPrecioElectrodomestico.Text = String.Empty;
        }

        private void AgregarClienteButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBoxNombreCliente.Text);
            cliente.Add(cliente);
            CargarClientes();
            textBoxNombreCliente.Text = String.Empty;
        }

        private void RealizarVentaButton_Click(object sender, EventArgs e)
        {
            Electrodomestico electrodomestico = [ListElectrodomestico.SelectedIndex];
            Cliente cliente = clientes[ListClientes.SelectedIndex];
            int precioVenta = int.Parse(textBoxPrecioElectrodomestico.Text);
            int cantidad = int.Parse(textBoxCantidad.Text);

            Venta venta = new Venta(electrodomestico, precioVenta, cantidad, cliente);

            venta.Add(venta);
            CargarVentas();
            textBoxPrecioElectrodomestico.Text=String.Empty;
            textBoxCantidad.Text = String.Empty;
        }

        private void EliminarElectrodomesticoButton_Click(object sender, EventArgs e)
        {
            Electrodomestico electrodomestico = [ListElectrodomestico.SelectedIndex];

            electrodomestico.Remove(electrodomestico);
            CargarElectrodomesticos();
        }

        private void EliminarClienteButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = [ListClientes.SelectedIndex];
            cliente.Remove(cliente);
            CargarClientes();
        }
        private void EliminarVentaButton_Click(object sender, EventArgs e)
        {
            Venta venta = [ListVentas];
            venta.Remove(venta);
            CargarVentas();
        }

    }
}