using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ayuntamiento
{
    public partial class InicioSesion : Form
    {
        String[] credenciales;
        List<Usuario> usuarios;
        String[,] puesto1 = { { "08:00 - 09:00", "Secretario Ayuntamiento" }, { "09:00 - 10:00", "Secretario Ayuntamiento" }, { "10:00 - 11:00", "Secretario Ayuntamiento" }, { "11:00 - 12:00", "Secretario Ayuntamiento" }, { "12:00 - 13:00", "Secretario Ayuntamiento" }, { "13:00 - 14:00", "Disponible" }, { "14:00 - 15:00", "Disponible" }, { "15:00 - 16:00", "Disponible" }, { "16:00 - 17:00", "Disponible" }, { "17:00 - 18:00", "Disponible" }, { "18:00 - 19:00", "Disponible" } };
        String[,] puesto2 = { { "08:00 - 09:00", "Disponible" }, { "09:00 - 10:00", "Disponible" }, { "10:00 - 11:00", "Disponible" }, { "11:00 - 12:00", "Disponible" }, { "12:00 - 13:00", "Disponible" }, { "13:00 - 14:00", "Disponible" }, { "14:00 - 15:00", "Disponible" }, { "15:00 - 16:00", "Disponible" }, { "16:00 - 17:00", "Disponible" }, { "17:00 - 18:00", "Disponible" }, { "18:00 - 19:00", "Disponible" } };
        String[,] puesto3 = { { "08:00 - 09:00", "Disponible" }, { "09:00 - 10:00", "Disponible" }, { "10:00 - 11:00", "Disponible" }, { "11:00 - 12:00", "Disponible" }, { "12:00 - 13:00", "Disponible" }, { "13:00 - 14:00", "Disponible" }, { "14:00 - 15:00", "Disponible" }, { "15:00 - 16:00", "Disponible" }, { "16:00 - 17:00", "Disponible" }, { "17:00 - 18:00", "Disponible" }, { "18:00 - 19:00", "Disponible" } };
        String[] impresion = { "A4 blanco y negro", "A4 color", "A3 blanco y negro", "A3 color" };
        int posUsuarioLogueado;
        Reserva reserva;
        Dictionary<string, double> precio_impresion;

        public InicioSesion()
        {
            InitializeComponent();
        }


        private void InicioSesion_Load(object sender, EventArgs e)
        {
            usuarios = new List<Usuario>();
            //obtener los usuarios de un archivo txt
            string listado_usuarios = Properties.Resources.credenciales.ToString();
            credenciales = listado_usuarios.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            crearUsuarios(credenciales);
            cargarCombos();
            cargaComboImpresion();
            precio_impresion = new Dictionary<String, double>();
            int i;
            double precio;
            //creacion del diccionario
            for (i = 0, precio = 0.5; i < impresion.Length; i++, precio += 0.5)
            {
                precio_impresion[impresion[i]] = precio;
            }
        }

        ///////////Panel Login///////////////

        //boton aceptar en Usuario y contraseña
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.ToLower().Trim();
            string contra = txtContra.Text;
            //si usuario está vacío
            if (nombre.Length == 0)
            {
                limpiarErrores();
                errorProvider1.SetError(txtUsuario, "Debe introducir un nombre de usuario");
            }
            //si contraseña está vacío
            else if (contra.Length == 0)
            {
                limpiarErrores();
                errorProvider1.SetError(txtContra, "Debe introducir una contraseña");
            }
            //si ninguno está vacío comprobar que existe el usuario
            else
            {
                //si es correcto Nombre y contraseña 
                if (buscarUsuario(nombre, contra))
                {
                    //comprueba si ya tiene 3 reservas a su nombre
                    if (usuarios[posUsuarioLogueado].getReservas().Count == 3)
                    {
                        String mensaje1 = "Lo sentimos, ya tiene 3 reservas.";
                        MessageBoxButtons botones1 = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje1, "Información", botones1);
                        cerrarSesion();
                    }
                    //si no tiene 3 reservas permite realizar más
                    else
                    {
                        limpiarErrores();
                        panelReservas.Visible = true;
                        panelLogin.Visible = false;
                        lblUsuario.Text = "Bienvenido, " + nombre;
                        btnAceptar.Enabled = true;
                    }
                }
            }
        }

        // a partir del string de credenciales, crea usuarios y contraseñas
        private void crearUsuarios(string[] credenciales)
        {
            for (int i = 0; i < credenciales.Length; i++)
            {
                string usuario = credenciales[i];
                i++;
                string password = credenciales[i];
                usuarios.Add(new Usuario(usuario, password));
            }
        }//fin metodo crear usuarios

        //metodo para comprobar usuario y contraseña
        private bool buscarUsuario(string nombre, string password)
        {
            //utiliza el metodo index of para encontrar la posición. si no lo encuentra devuelve -1
            int pos = usuarios.IndexOf(new Usuario(nombre));
            bool encontrado = false;
            if (pos != -1)
            {
                String contra = usuarios[pos].getContra();
                //compara la contraseña encontrada con la introducida
                if (contra.Equals(password))
                {
                    encontrado = true;
                    posUsuarioLogueado = pos;
                }
                else
                {
                    limpiarErrores();
                    errorProvider1.SetError(txtContra, "Contraseña incorrecta");
                }
            }
            //si el valor es -1
            else
            {
                limpiarErrores();
                errorProvider1.SetError(txtUsuario, "Usuario no existe");
            }
            return encontrado;
        }//fin metodo buscar usuario

        //metodo para borrar los errores provider
        private void limpiarErrores()
        {
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtContra, "");
            errorProvider1.SetError(cmbPuesto1, "");

        }

        //elimina el texto introducido en usuario y contraseña
        private void limpiar()
        {
            txtContra.Text = "";
            txtUsuario.Text = "";
        }

        //boton salir de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //////////Panel Reservas/////////////////////

        //boton cerrar sesión        
        private void btnSesion_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Seguro que deseas salir?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            var botonPulsado = MessageBox.Show(mensaje, "Información", botones);

            if (botonPulsado == DialogResult.Yes)
            {
                cerrarSesion();
            }
        }

        //elimina el contenido de los combos y los vuelve a cargar por si se han producido modificaciones
        private void reestablecerCombos()
        {
            cmbPuesto1.Items.Clear();
            cmbPuesto2.Items.Clear();
            cmbPuesto3.Items.Clear();
            cargarCombos();
            combosResetText();
            cmbImpresion.SelectedIndex = -1;
        }

        //Elimina el texto que se haya podido quedar en el combo
        private void combosResetText()
        {
            cmbPuesto1.ResetText();
            cmbPuesto2.ResetText();
            cmbPuesto3.ResetText();

        }

        //elimina los iconos de error que esten visibles
        private void limpiarErroresReserva()
        {
            errorProvider1.SetError(cmbPuesto1, "");
            errorProvider1.SetError(cmbPuesto2, "");
            errorProvider1.SetError(cmbPuesto3, "");
        }


        //carga la informacion de los combos de los puestos
        private void cargarCombos()
        {
            //Combo reservas puesto1
            for (int i = 0; i < puesto1.GetLength(0); i++)
            {
                string hora = puesto1[i, 0];
                string estado = puesto1[i, 1];
                cmbPuesto1.Items.Add(hora + " - " + estado);
            }
            //combo reservas puesto2
            for (int i = 0; i < puesto2.GetLength(0); i++)
            {
                string hora = puesto2[i, 0];
                string estado = puesto2[i, 1];
                cmbPuesto2.Items.Add(hora + " - " + estado);
            }
            //combo reservas puesto3
            for (int i = 0; i < puesto3.GetLength(0); i++)
            {
                string hora = puesto3[i, 0];
                string estado = puesto3[i, 1];
                cmbPuesto3.Items.Add(hora + " - " + estado);
            }
        }

        //carga la informacion del combo de impresion
        private void cargaComboImpresion()
        {
            for (int i = 0; i < impresion.GetLength(0); i++)
            {
                cmbImpresion.Items.Add(impresion[i]);
            }
        }

        //boton aceptar del panel de reservas
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            limpiarErrores();

            //comprueba que se haya seleccionado algun puesto
            if (cmbPuesto1.SelectedIndex == -1 && cmbPuesto2.SelectedIndex == -1 && cmbPuesto3.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPuesto1, "Debe seleccionar un puesto");
            }


            //si todo está correcto crea una nueva reserva
            else
            {
                String nombre = txtUsuario.Text;
                //si ha seleccionado impresion
                if (cmbImpresion.SelectedIndex != -1)
                {
                    nombre = txtUsuario.Text + "-I";
                }
                //si ha elegido el puesto 1
                if (cmbPuesto1.SelectedIndex != -1)
                {
                    int seleccion = cmbPuesto1.SelectedIndex;
                    //comprueba que el puesto esté disponible
                    if (puesto1[seleccion, 1].Equals("Disponible"))
                    {
                        string puesto = "puesto 1";
                        //se obtiene la hora extraida del combo
                        string hora = puesto1[cmbPuesto1.SelectedIndex, 0];
                        //crea un objeto tipo Reserva
                        reserva = new Reserva(puesto, hora, nombre);
                        mostrarReserva(nombre, puesto, hora);
                        //sustituye "Disponible" por el nombre del usuario
                        puesto1[cmbPuesto1.SelectedIndex, 1] = nombre;
                        reservaBienHecha(reserva);
                    }
                    else
                    {
                        errorProvider1.SetError(cmbPuesto1, "Hora ocupada. Elija una opción disponible");
                    }
                }
                else
                {
                    //si ha elegido el puesto2
                    if (cmbPuesto2.SelectedIndex != -1)
                    {
                        int seleccion = cmbPuesto2.SelectedIndex;
                        //comprueba que el puesto esté disponible
                        if (puesto2[seleccion, 1].Equals("Disponible"))
                        {
                            string puesto = "puesto 2";
                            //se obtiene la hora extraida del combo
                            string hora = puesto2[cmbPuesto2.SelectedIndex, 0];
                            //crea un objeto tipo Reserva
                            reserva = new Reserva(puesto, hora, nombre);
                            mostrarReserva(nombre, puesto, hora);
                            //sustituye "Disponible" por el nombre del usuario
                            puesto2[cmbPuesto2.SelectedIndex, 1] = nombre;
                            reservaBienHecha(reserva);
                        }
                        else
                        {
                            errorProvider1.SetError(cmbPuesto2, "Hora ocupada. Elija una opción disponible");
                        }

                    }
                    //si no es el 1 o el 2, es el 3
                    else
                    {
                        int seleccion = cmbPuesto3.SelectedIndex;
                        //comprueba que el puesto esté disponible
                        if (puesto3[seleccion, 1].Equals("Disponible"))
                        {
                            string puesto = "puesto 3";
                            //se obtiene la hora extraida del combo
                            string hora = puesto3[cmbPuesto3.SelectedIndex, 0];
                            //crea un objeto tipo Reserva
                            reserva = new Reserva(puesto, hora, nombre);
                            mostrarReserva(nombre, puesto, hora);
                            //sustituye "Disponible" por el nombre del usuario
                            puesto3[cmbPuesto3.SelectedIndex, 1] = nombre;
                            reservaBienHecha(reserva);
                        }
                        else
                        {
                            errorProvider1.SetError(cmbPuesto3, "Hora ocupada.Elija una opción disponible");
                        }
                    }
                }
            }
        }

        //añade la reserva al usuario. Hace visible el panel de informacion, oculta el panel de reserva y reestablece los combos
        private void reservaBienHecha(Reserva reserva)
        {
            panelInformacion.Visible = true;
            usuarios[posUsuarioLogueado].setReserva(reserva);
            reestablecerCombos();
            panelReservas.Visible = false;
        }

        //carga la información de la reserva en el panel de información
        private void mostrarReserva(string nombre, string puesto, string hora)
        {
            lblNombre.Text = nombre;
            lblHora.Text = hora;
            lblPuesto.Text = puesto;
            //si ha elegido impresión
            if (cmbImpresion.SelectedIndex != -1)
            {
                // Crea una instancia de la clase Random para obtener un codigo aleatorio
                Random rand = new Random();
                // Genera un número aleatorio entre el 1 y el 50
                int numeroAleatorio = rand.Next(1, 51);
                String impresionElegida = cmbImpresion.Text;
                lblImpresion.Visible = true;
                lblPrecio.Visible = true;
                lblImpresion.Text = impresionElegida;
                lblPrecio.Text = precio_impresion[cmbImpresion.Text] + " €";
                lblTitulo.Visible = true;
                lblCodigo.Visible = true;
                lblCodigo.Text = "Código: " + numeroAleatorio;
            }
            //si no ha elegido impresión
            else
            {
                lblImpresion.Visible = false;
                lblPrecio.Visible = false;
                lblTitulo.Visible = false;
                lblCodigo.Visible = false;
            }
        }

        //botón aceptar del panel de información de la reserva
        private void btnOK_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Quieres realizar otra reserva?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            var botonPulsado = MessageBox.Show(mensaje, "Información", botones);
            panelInformacion.Visible = false;
            if (botonPulsado == DialogResult.No)
            {
                cerrarSesion();
            }
            else
            {
                //recuento del numero de reservas del usuario logueado
                if (usuarios[posUsuarioLogueado].getReservas().Count == 3)
                {
                    String mensaje1 = "Lo sentimos, no puede realizar más de 3 reservas";
                    MessageBoxButtons botones1 = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje1, "Información", botones1);
                    cerrarSesion();
                }
                else
                {
                    panelReservas.Visible = true;
                }
            }
        }

        //boton cerrar sesion del panel de reservas
        private void cerrarSesion()
        {
            limpiar();
            reestablecerCombos();
            panelReservas.Visible = false;
            panelLogin.Visible = true;
        }

        ///////////control de los radioButtons//////////
        private void rdPuesto1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPuesto1.Checked)
            {
                combosResetText();
                limpiarErroresReserva();
                cmbPuesto1.Enabled = true;
                cmbPuesto2.Enabled = false;
                cmbPuesto3.Enabled = false;
            }
        }

        private void rdPuesto2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPuesto2.Checked)
            {
                combosResetText();
                limpiarErroresReserva();
                cmbPuesto2.Enabled = true;
                cmbPuesto3.Enabled = false;
                cmbPuesto1.Enabled = false;
            }
        }

        private void rdPuesto3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPuesto3.Checked)
            {
                combosResetText();
                limpiarErroresReserva();
                cmbPuesto3.Enabled = true;
                cmbPuesto2.Enabled = false;
                cmbPuesto1.Enabled = false;
            }
        }
    }
}
