namespace Packaging_Calculation
{
    using silicaGel = Packaging_Calculation.SilicaGel;
    using oxygenAbs = Packaging_Calculation.OxygenAbsorber;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Silica Gel

        private void sg_Length_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void sg_width_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sg_height_ValueChanged(object sender, EventArgs e)
        {

        }
        // Oxygen Absorber
        private void ox_length_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ox_width_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ox_height_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ox_foodWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSGSubmit_Click(object sender, EventArgs e)
        {
            silicaGel sg = new silicaGel((float)sg_height.Value, (float)sg_Length.Value , (float)sg_width.Value);
            SG_PackageVolume.Text = sg.PackageVolume().ToString("0,0.00");
            SG_SilicaGelVolume.Text = sg.SlilcaGelVolume().ToString("0,0.00");
        }

        private void btnOXASubmit_Click(object sender, EventArgs e)
        {
            oxygenAbs oxa = new oxygenAbs((float)ox_length.Value, (float)ox_width.Value, (float)ox_height.Value, (float)ox_foodWeight.Value);
            OX_PackageVolume.Text = oxa.PackageVolume().ToString("0,0.00");
            OX_Oxygen_Absorber_Volume.Text = oxa.OxygenAbsorberVolume().ToString("0,0.00");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Oxygen_absorber_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void SG_PackageVolume_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}