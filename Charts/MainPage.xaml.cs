using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Charts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Microcharts.Entry> entries = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(200)
            {
                Color = SKColor.Parse("#ff1493"),
                Label = "January",
                ValueLabel = "200"
            },

             new Microcharts.Entry(300)
            {
                Color = SKColor.Parse("#ff0000"),
                Label = "February",
                ValueLabel = "300"
            },

              new Microcharts.Entry(100)
            {
                Color = SKColor.Parse("#3633FF"),
                Label = "March",
                ValueLabel = "100"
            },
        };
        public MainPage()
        {
            InitializeComponent();
            Chart1.Chart = new BarChart() { Entries = entries, Margin = 5 };
            Chart1.EnableTouchEvents = true;

            Chart2.Chart = new DonutChart() { Entries = entries };
            Chart2.EnableTouchEvents = true;

            Chart3.Chart = new PointChart() { Entries = entries };
            Chart3.EnableTouchEvents = true;

            Chart4.Chart = new LineChart() { Entries = entries };
            Chart4.EnableTouchEvents = true;

            Chart5.Chart = new RadialGaugeChart() { Entries = entries };
            Chart5.EnableTouchEvents = true;
        }
    }
}