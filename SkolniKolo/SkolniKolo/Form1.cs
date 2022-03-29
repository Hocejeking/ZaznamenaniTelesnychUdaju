using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace SkolniKolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public static Dictionary<DateTime, miry> zaznam = new Dictionary<DateTime,miry>();

        string datum = "";
        int vaha =0;
        int pas =0;
        int boky =0;
        int prsa=0;
        int stehna=0;
        int paze=0;

        private void btnZapis_Click(object sender, EventArgs e)
        {
            miry miry = new miry(dtPicker.Value,Convert.ToInt32(txtBoxVaha.Text),Convert.ToInt32(txtBoxPas.Text), Convert.ToInt32(txtBoxBoky.Text), Convert.ToInt32(txtBoxPrsa.Text), Convert.ToInt32(txtBoxStehna.Text), Convert.ToInt32(txtBoxPaze.Text));

            if(zaznam.ContainsKey(dtPicker.Value.Date))
            {
                MessageBox.Show("Z�znam pro dan� datum byl ji� p�id�n.");
            }
            else
            {
                zaznam.Add(dtPicker.Value.Date, miry);
                MessageBox.Show("Z�znam �sp�n� p�id�n");
                
            }

            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
           
                if (zaznam.ContainsKey(dtPicker.Value.Date))
                {
                    
                    
                    foreach(miry m in zaznam.Values)
                    {

                        if(m.Datum == dtPicker.Value.Date.ToString())
                        {
                            txtBox.Text = "Datum : " + m.Datum.ToString() + Environment.NewLine + "V�ha : " + m.Vaha.ToString() + Environment.NewLine + "Pas : " + m.Pas.ToString() + Environment.NewLine + "Boky : " + m.Boky.ToString() + Environment.NewLine + "Prsa : " + m.Prsa.ToString() + Environment.NewLine + "Stehna : " + m.Stehna.ToString() + Environment.NewLine + "Pa�e : " + m.Paze.ToString();
                            MessageBox.Show("text bylo zobrazen");
                        }
                       
                    }
                                  
                }
                else
                {
                MessageBox.Show("Z�znam pro tento den je�t� nep�id�n");
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
           
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.UTF32);

                foreach (miry m in zaznam.Values)
                {
                        stream.WriteLine("Datum : " + m.Datum.ToString() + Environment.NewLine + "V�ha : " + m.Vaha.ToString() + Environment.NewLine + "Pas : " + m.Pas.ToString() + Environment.NewLine + "Boky : " + m.Boky.ToString() + Environment.NewLine + "Prsa : " + m.Prsa.ToString() + Environment.NewLine + "Stehna : " + m.Stehna.ToString() + Environment.NewLine + "Pa�e : " + m.Paze.ToString());
                }

                stream.Close();

            }

            MessageBox.Show("Z�znamy byly vytvo�eny v dan�m souboru");

            
            
        }

        private void btnPorovnani_Click(object sender, EventArgs e)
        {
           

            if (dtPicker.Value != null && dtPickerPorovnani.Value != null)
            {  

                if(dtPicker.Value == dtPickerPorovnani.Value)
                {
                    MessageBox.Show("Data pro porovn�n� nem��ou b�t stejn�");
                }
                else if (dtPicker.Value != dtPickerPorovnani.Value)
                {
                    
                    foreach (miry m in zaznam.Values)
                    {
                        if(m.Datum == dtPicker.Value.Date.ToString())
                        {
                            datum = m.Datum;
                             vaha = m.Vaha;
                              pas = m.Pas;
                             boky = m.Boky;
                             prsa = m.Prsa;
                           stehna = m.Stehna;
                             paze = m.Paze; 

                        }

                        if(m.Datum == dtPickerPorovnani.Value.Date.ToString())
                        {

                            if (vaha != 0)
                            {
                                txtBox.Text = "P�vodn� datum : " + datum.ToString() + " Datum por." + m.Datum.ToString() + Environment.NewLine + "P�vodn� v�ha: " + vaha.ToString() + " V�ha por.: " + m.Vaha.ToString() + Environment.NewLine +"P�vodn� pas: " +
                                pas.ToString() + " Pas por.: " + m.Pas.ToString() + Environment.NewLine +  "P�vodn� boky: " + boky.ToString() + " boky por.: " + m.Boky.ToString() + Environment.NewLine +"P�vodn� prsa: " + prsa.ToString() + " Prsa por.: " +
                                m.Prsa.ToString() + Environment.NewLine +"P�vodn� stehna: " + stehna.ToString() + " Stehna por.: " + m.Stehna + Environment.NewLine +"P�vodn� pa�e: " + paze.ToString() + " Paze por.: " + m.Paze;
                            }
                        }
                        
                        

                    }
                }


            }
            

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            
        }
    }
}