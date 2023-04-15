using Plot3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Plot3D.Graph3D;

namespace Graph3D
{
    public partial class Form1 : Form
    {
        List<double> P_0_0 = new List<double>() { 0, 0, 1 };
        List<double> P_0_1 = new List<double>() { 1, 1, 1 };
        List<double> P_1_0 = new List<double>() { 0, 1, 0 };
        List<double> P_1_1 = new List<double>() { 1, 0, 0 };

        List<cScatter> i_List = new List<cScatter>();

        double xRatation = 0.0;
        double yRatation = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void graph3D1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void getAllValues() {
            try
            {
                P_0_0[0] = Convert.ToDouble(P00X.Text);
            }
            catch
            {
                P_0_0[0] = Convert.ToDouble(0);
            };



            try
            {
                P_0_0[1] = Convert.ToDouble(P00Y.Text);
            }
            catch
            {
                P_0_0[1] = Convert.ToDouble(0);
            };



            try
            {
                P_0_0[2] = Convert.ToDouble(P00Z.Text);
            }
            catch
            {
                P_0_0[2] = Convert.ToDouble(1);
            };



            try
            {
                P_0_1[0] = Convert.ToDouble(P01X.Text);
            }
            catch
            {
                P_0_1[0] = Convert.ToDouble(1);
            };



            try
            {
                P_0_1[1] = Convert.ToDouble(P01Y.Text);
            }
            catch
            {
                P_0_1[1] = Convert.ToDouble(1);
            };



            try
            {
                P_0_1[2] = Convert.ToDouble(P01Z.Text);
            }
            catch
            {
                P_0_1[2] = Convert.ToDouble(1);
            };



            try
            {
                P_1_0[0] = Convert.ToDouble(P10X.Text);
            }
            catch
            {
                P_1_0[0] = Convert.ToDouble(0);
            };



            try
            {
                P_1_0[1] = Convert.ToDouble(P10Y.Text);
            }
            catch
            {
                P_1_0[1] = Convert.ToDouble(1);
            };



            try
            {
                P_1_0[2] = Convert.ToDouble(P10Z.Text);
            }
            catch
            {
                P_1_0[2] = Convert.ToDouble(0);
            };

            try
            {
                P_1_1[0] = Convert.ToDouble(P11X.Text);
            }
            catch
            {
                P_1_1[0] = Convert.ToDouble(1);
            };



            try
            {
                P_1_1[1] = Convert.ToDouble(P11Y.Text);
            }
            catch
            {
                P_1_1[1] = Convert.ToDouble(0);
            };


            try
            {
                P_1_1[2] = Convert.ToDouble(P11Z.Text);
            }
            catch
            {
                P_1_1[2] = Convert.ToDouble(0);
            };



            

        }
        private void getAllPoints() {
            List<double> tempP_0_0 = new List<double>() { P_0_0[0], P_0_0[1], P_0_0[2] };
            List<double> tempP_0_1 = new List<double>() { P_0_1[0], P_0_1[1], P_0_1[2] };
            List<double> tempP_1_0 = new List<double>() { P_1_0[0], P_1_0[1], P_1_0[2] };
            List<double> tempP_1_1 = new List<double>() { P_1_1[0], P_1_1[1], P_1_1[2] };

            double X;
            double Y;
            double Z;
            double tempX;
            double tempY;
            double tempZ;


            for (double u = 0; u <= 1; u += 0.05)
            {
                for (double w = 0; w <= 1; w += 0.05)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        tempP_0_0[i] = P_0_0[i] * (1 - u) * (1 - w);
                        tempP_0_1[i] = P_0_1[i] * (1 - u) * w;
                        tempP_1_0[i] = P_1_0[i] * u * (1 - w);
                        tempP_1_1[i] = P_1_1[i] * u * w;

                        

                    }

                    X = tempX = tempP_0_0[0] + tempP_0_1[0] + tempP_1_0[0] + tempP_1_1[0];
                    Y = tempY= tempP_0_0[1] + tempP_0_1[1] + tempP_1_0[1] + tempP_1_1[1];
                    Z = tempZ = tempP_0_0[2] + tempP_0_1[2] + tempP_1_0[2] + tempP_1_1[2];

                    tempX = X;
                    tempY = Y*Math.Cos(xRatation)+Z*Math.Sin(xRatation);
                    tempZ = -Y*Math.Sin(xRatation) + Z*Math.Cos(xRatation);
                    X = tempX;
                    Y = tempY;
                    Z = tempZ;
                    
                   tempX = X * Math.Cos(yRatation) + Z * Math.Sin(yRatation);
                   tempY = Y;
                   tempZ = -X * Math.Sin(yRatation) + Z * Math.Cos(yRatation);
                   X = tempX;
                   Y = tempY;
                   Z = tempZ;
                   i_List.Add(new cScatter(X, Y,Z, null));
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            getAllPoints();            

            graph3D1.Raster = eRaster.Labels; // Show axis, raster lines, labels

            // You can also specify MaintainXY or MaintainXYZ here
            graph3D1.SetScatterPoints(i_List.ToArray(), eNormalize.Separate);
            i_List.Clear();
        }

        private void POOX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_0_0[0] = Convert.ToDouble(P00X.Text);
            }
            catch { P_0_0[0] = Convert.ToDouble(0);
            };
        }

        private void POOY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_0_0[1] = Convert.ToDouble(P00Y.Text);
            }
            catch
            {
                P_0_0[1] = Convert.ToDouble(0);
            };
        }

        private void POOZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_0_0[2] = Convert.ToDouble(P00Z.Text);
            }
            catch
            {
                P_0_0[2] = Convert.ToDouble(1);
            };
        }

        private void PO1X_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_0_1[0] = Convert.ToDouble(P01X.Text);
            }
            catch
            {
                P_0_1[0] = Convert.ToDouble(1);
            };
        }

        private void PO1Y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_0_1[1] = Convert.ToDouble(P01Y.Text);
            }
            catch
            {
                P_0_1[1] = Convert.ToDouble(1);
            };
        }

        private void PO1Z_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_0_1[2] = Convert.ToDouble(P01Z.Text);
            }
            catch
            {
                P_0_1[2] = Convert.ToDouble(1);
            };
        }

        private void P10X_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_1_0[0] = Convert.ToDouble(P10X.Text);
            }
            catch
            {
                P_1_0[0] = Convert.ToDouble(0);
            };
        }

        private void P10Y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_1_0[1] = Convert.ToDouble(P10Y.Text);
            }
            catch
            {
                P_1_0[1] = Convert.ToDouble(1);
            };
        }

        private void P10Z_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_1_0[2] = Convert.ToDouble(P10Z.Text);
            }
            catch
            {
                P_1_0[2] = Convert.ToDouble(0);
            };
        }

        private void P11X_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_1_1[0] = Convert.ToDouble(P11X.Text);
            }
            catch
            {
                P_1_1[0] = Convert.ToDouble(1);
            };
        }

        private void P11Y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_1_1[1] = Convert.ToDouble(P11Y.Text);
            }
            catch
            {
                P_1_1[1] = Convert.ToDouble(0);
            };
        }

        private void P11Z_TextChanged(object sender, EventArgs e)
        {
            try
            {
                P_1_1[2] = Convert.ToDouble(P11Z.Text);
            }
            catch
            {
                P_1_1[2] = Convert.ToDouble(0);
            };

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void xRat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                xRatation = Convert.ToDouble(Convert.ToInt32(xRat.Text) * 3.14 /180 );
            }
            catch
            {
                xRatation = Convert.ToDouble(0);
            };
            
        }

        private void yRat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yRatation = Convert.ToDouble(Convert.ToInt32(yRat.Text) * 3.14/ 180 );
            }
            catch
            {
                yRatation = Convert.ToDouble(0);
            };
            
        }
        
    }
    
}
