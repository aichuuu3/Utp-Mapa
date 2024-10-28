using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace UTPMaps
{
    public partial class Form1 : Form
    {
        private GMapControl gMapControl;
        public Form1()
        {
            InitializeComponent();
            
            gMapControl = new GMapControl();
            gMapControl.Dock = DockStyle.Fill; // Ajusta el control al tamaño del formulario --> por si se me olvida
            this.Controls.Add(gMapControl);

            // Configura el mapa
            gMapControl.MapProvider = GMapProviders.GoogleMap; 
            gMapControl.Position = new GMap.NET.PointLatLng(9.02395, -79.53172); // Coordenadas de la utp
            gMapControl.MinZoom = 2; /*Zoom mínimo*/
            gMapControl.MaxZoom = 18; /*Zoom máximo*/
            gMapControl.Zoom = 17; /*Zoom inicial*/

            // implementa la interfaz uwu
            gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl.CanDragMap = true;
            gMapControl.ShowTileGridLines = false;
        }
    }
}
