
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Text.Json;
using System.Drawing;

namespace appTestJSON
{
    public partial class Form1 : Form {

        private int a = 1;
        public Form1()
        {
            InitializeComponent();
        }
        public Image ReadSerie(string url)
        {
            try
            {
               
                
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = "application/json";
                //request.
                //request.Credentials = new NetworkCredential("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
                //request.Headers.Add("api_key","sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
                //request.Headers.Add("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
                //
                //request.Headers["api_key"] = "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                //object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                //Response jsonResponse = objResponse as Response;
                //Image datos = JsonSerializer.Deserialize<Image>(response.GetResponseStream());
                //return datos;
                using (var stream = response.GetResponseStream())
                {
                   return Bitmap.FromStream(stream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return null;
        }
        public string Meses(int mes) {
            string []s= { "01","02", "03", "04", "05","06","07","08","09","10","11","12"};
            return s[mes-1];
        }
        public string Dia(int dia)
        {
            string[] s = { "01", "02", "03", "04", "05", "06", "07", "08", "09",
                "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
            "30", "31"};
            return s[dia - 1];
        }
        public  List<DataSerie> ReadSerie(DateTime Inicio,DateTime Final)
        {
            try
            {
                string filtro = "start_date="+ Inicio.Year.ToString() + "-"+Meses(Inicio.Month)+
                    "-"+Dia(Inicio.Day)+"&end_date=" + Final.Year.ToString() + "-" + Meses(Final.Month) +
                    "-" + Dia(Final.Day) + "&";
                string url = "https://api.nasa.gov/planetary/apod?"+filtro+"api_key=sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ";
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = "application/json";
                //request.
                //request.Credentials = new NetworkCredential("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
                //request.Headers.Add("api_key","sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
                //request.Headers.Add("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
                //
                //request.Headers["api_key"] = "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                try {
                    if(response.Headers["X-RateLimit-Remaining"] != null) {
                        a = System.Convert.ToInt32(response.Headers["X-RateLimit-Remaining"]); }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                List<DataSerie> datos = JsonSerializer.Deserialize<List<DataSerie>>(response.GetResponseStream());

                //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                //object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                //Response jsonResponse = objResponse as Response;
                //return jsonResponse;
                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled= false;
            listFotos.Enabled= false;
            btnFiltrar.Enabled= false;
            if (listFotos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una imagen");
               
            }
            else
            {
                DataSerie filt = listFotos.SelectedItem as DataSerie;
                Image response;

                    if (btnHD.Checked)
                    {
                        response = ReadSerie(filt.hdurl);
                    }
                    else
                    {
                        response = ReadSerie(filt.url);
                    }

                    picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    picFoto.Image = response;

            }

            button1.Enabled = true;
            listFotos.Enabled = true;
            btnFiltrar.Enabled = true;
            //Serie serie = response.seriesResponse.series[0];
            //label1.Text="Serie: "+ serie.Title+Environment.NewLine;
            //foreach (DataSerie dataSerie in serie.Data)
            //{
            //    if (dataSerie.Data.Equals("N/E")) continue;
            //    label1.Text+="Fecha: "+dataSerie.Date + Environment.NewLine;
            //    label1.Text+= "Dato: "+ dataSerie.Data + Environment.NewLine;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            listFotos.Enabled = false;
            button1.Enabled = false;
            listFotos.Text = "";
            picFoto.Image = null;
            if (a > 0)
            {
                List<DataSerie> response = ReadSerie(dtpInicial.Value, dtpFinal.Value);
                listFotos.Items.Clear();
                foreach (DataSerie a in response)
                {
                    listFotos.Items.Add(a);
                }
                listFotos.Enabled = true;
                button1.Enabled = true;
            }
            else {
                MessageBox.Show("No quedan intentos. Trate mañana");
                btnFiltrar.Enabled = false;
            }
            

        }

        private void btnNorm_CheckedChanged(object sender, EventArgs e)
        {
            //if (btnNorm.Checked == false)
            //{
            //    btnHD.Checked = true;
            //}
            //else {
            //    btnHD.Checked = false;
            //}
        }

        private void btnHD_CheckedChanged(object sender, EventArgs e)
        {
            
            //btnNorm.Checked = false;
        }
    }
}
