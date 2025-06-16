using System.Globalization;
using System.Text;

namespace CurpLibrery
{
    public partial class Curp : UserControl
    {
        private string gen;
        public event EventHandler CurpActualizada;

        private static Dictionary <string, string> clavesEstados = new Dictionary <string, string>
        {
            {"AGUASCALIENTES", "AS"},
            {"BAJA CALIFORNIA", "BC"},
            {"BAJA CALIFORNIA SUR", "BS"},
            {"CAMPECHE", "CC"},
            {"COAHUILA", "CL"},
            {"COLIMA", "CM"},
            {"CHIAPAS", "CS"},
            {"CHIHUAHUA", "CH"},
            {"CIUDAD DE MÉXICO", "DF"},
            {"DURANGO", "DG"},
            {"GUANAJUATO", "GT"},
            {"GUERRERO", "GR"},
            {"HIDALGO", "HG"},
            {"JALISCO", "JC"},
            {"MÉXICO", "MC"},
            {"MICHOACÁN", "MN"},
            {"MORELOS", "MS"},
            {"NAYARIT", "NT"},
            {"NUEVO LEÓN", "NL"},
            {"OAXACA", "OC"},
            {"PUEBLA", "PL"},
            {"QUERÉTARO", "QT"},
            {"QUINTANA ROO", "QR"},
            {"SAN LUIS POTOSÍ", "SP"},
            {"SINALOA", "SL"},
            {"SONORA", "SR"},
            {"TABASCO", "TC"},
            {"TAMAULIPAS", "TS"},
            {"TLAXCALA", "TL"},
            {"VERACRUZ", "VZ"},
            {"YUCATÁN", "YN"},
            {"ZACATECAS", "ZS"},
            {"NACIDO EN EL EXTRANJERO", "NE"}
        };

        public Curp()
        {
            gen = string.Empty;
            InitializeComponent();
            cbSexo.SelectedIndex = 0;
            cboEstado.DataSource = Entidad.estados;
            cboEstado.SelectedIndex = 0;
            CurpActualizada += (s, e) => { lblCurp.Text = gen; };
        }

        public string CurpGenerada
        {
            get { 
                return gen; 
            }
            set { 
                gen = value; 
            }
        }

        public string Nombre
        {
            get {
                return txtNombres.Text;
            }
            set { 
                txtNombres.Text = value;
            }
        }

        public string PrimerApellido
        {
            get { 
                return txtApellidoPa.Text;
            }
            set { 
                txtApellidoPa.Text = value; 
            }
        }

        public string SegundoApellido
        {
            get {
                return txtApellidoMa.Text;
            }
            set { 
                txtApellidoMa.Text = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get { 
                return dtpfecha.Value;
            }
            set { 
                dtpfecha.Value = value;
            }
        }

        public string Genero
        {
            get {
                return cbSexo.SelectedItem != null ? cbSexo.SelectedItem.ToString().ToUpper() : "";
         ; 
            }
            set { 
                cbSexo.SelectedItem = value; 
            }
        }

        public string Estado
        {
            get { 
                return cboEstado.SelectedItem != null ? cboEstado.SelectedItem.ToString().ToUpper() : ""; 
            }
            set { 
                cboEstado.SelectedItem = value; 
            }
        }

        private void Mostrar()
        {
            lblCurp.Text = gen;
            CurpActualizada?.Invoke(this, EventArgs.Empty);
        }

        private void GenerarCurp()
        {
            if (string.IsNullOrWhiteSpace(PrimerApellido) || PrimerApellido.Length < 2 ||
                string.IsNullOrWhiteSpace(SegundoApellido) || SegundoApellido.Length < 1 ||
                string.IsNullOrWhiteSpace(Nombre) || Nombre.Length < 1)
            {
                gen = "";
                Mostrar();
                return;
            }

            string Acentos(string texto)
            {
                return string.Concat(texto.Normalize(NormalizationForm.FormD)
                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark))
                    .Normalize(NormalizationForm.FormC);
            }

            char PrimeraVocal(string texto)
            {
                foreach (char c in texto.Skip(1))
                {
                    if ("AEIOU".Contains(c)) return c;
                }
                return 'X';
            }

            char PrimeraConsonante(string texto)
            {
                foreach (char c in texto.Skip(1))
                {
                    if ("BCDFGHJKLMNPQRSTVWXYZ".Contains(c)) return c;
                }
                return 'X';
            }

            string NombreCurp(string nombre)
            {
                string[] ignorados = { "MARIA", "JOSE", "MA", "J" };
                string[] partes = nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (partes.Length == 0) return "";
                if (ignorados.Contains(partes[0]) && partes.Length > 1) return partes[1];

                return partes[0];
            }

            string pa = Acentos(PrimerApellido.ToUpper());
            string sa = Acentos(SegundoApellido.ToUpper());
            string nom = Acentos(Nombre.ToUpper());
            string nomCurp = NombreCurp(nom);

            string sexo = Genero.StartsWith("H") ? "H" : "M";

            string estado = clavesEstados.ContainsKey(Estado) ? clavesEstados[Estado] : "NE";

            gen = pa[0].ToString()+PrimeraVocal(pa)+sa[0].ToString()+nomCurp[0].ToString()+FechaNacimiento.ToString("yyMMdd") +
                  sexo+estado+PrimeraConsonante(pa)+PrimeraConsonante(sa)+PrimeraConsonante(nomCurp) + "A1";
            Mostrar();

        }

        

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            GenerarCurp();
        }

        public static class Entidad
        {
            public static string[] estados = new string[]
            {
                "AGUASCALIENTES", "BAJA CALIFORNIA", "BAJA CALIFORNIA SUR", "CAMPECHE", "COAHUILA",
                "COLIMA", "CHIAPAS", "CHIHUAHUA", "CIUDAD DE MÉXICO", "DURANGO", "GUANAJUATO",
                "GUERRERO", "HIDALGO", "JALISCO", "MÉXICO", "MICHOACÁN", "MORELOS", "NAYARIT",
                "NUEVO LEÓN", "OAXACA", "PUEBLA", "QUERÉTARO", "QUINTANA ROO", "SAN LUIS POTOSÍ",
                "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ",
                "YUCATÁN", "ZACATECAS", "NACIDO EN EL EXTRANJERO"
            };
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void txtApellidoPa_TextChanged_1(object sender, EventArgs e)
        {
            GenerarCurp();
        }

        private void txtNombres_TextChanged_1(object sender, EventArgs e)
        {
            GenerarCurp();
        }

        private void txtApellidoMa_TextChanged_1(object sender, EventArgs e)
        {
            GenerarCurp();
           
        }

        private void cbSexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GenerarCurp();
        }

        private void cboEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GenerarCurp();
        }
    }
}

