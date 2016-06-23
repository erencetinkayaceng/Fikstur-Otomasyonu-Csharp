using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HakemOtomasyonTD.Configure
{
    class ComponentConfiguration
    {
        private static ComponentConfiguration _configure;

        private Font labelFont;
        private Font butonFont;
        private Color panelBgcolorTip1;
        private Color panelBgcolorTip2;

        private ComponentConfiguration()
        {
            configureDosyayiOku();
        }

        private static ComponentConfiguration nesneAl
        {
            get
            {
                if (_configure == null)
                {
                    _configure = new ComponentConfiguration();
                }
                return _configure;

            }
            set
            {
                _configure = value;
            }

        }

        public static ComponentConfiguration configureGetir()
        {
            return nesneAl;
        }

        private void configureDosyayiOku()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("..\\..\\componentsconfig.xml");
            XmlNode etiketler = xdoc.SelectSingleNode("components");

            foreach (XmlNode node in etiketler.SelectNodes("label"))
            {
                int size = Int32.Parse(node.SelectSingleNode("font-size").InnerText);
                string style = node.SelectSingleNode("font-style").InnerText;
                labelFont = new Font(style, size);
            }
            foreach (XmlNode node in etiketler.SelectNodes("buton"))
            {
                int size=Int32.Parse(node.SelectSingleNode("font-size").InnerText);
                string style = node.SelectSingleNode("font-style").InnerText;
                butonFont = new Font(style, size);
            }
            foreach (XmlNode node in etiketler.SelectNodes("panel"))
            {
                if (node.Attributes["tip"].Value == "birinci")
                {
                    panelBgcolorTip1 = Color.FromName(node.SelectSingleNode("bgcolor").InnerText) ;
                }
                else if (node.Attributes["tip"].Value == "ikinci")
                {
                    panelBgcolorTip2 = Color.FromName(node.SelectSingleNode("bgcolor").InnerText);
                }
            }
        }

        public Font getLabelFont
        {
            get
            {
                return labelFont;
            }
        }

        public Font getButonFont
        {
            get
            {
                return butonFont;
            }
        }

        public Color getPanelBgcolorTip1
        {
            get
            {
                return panelBgcolorTip1;
            }
        }

        public Color getPanelBgcolorTip2
        {
            get
            {
                return panelBgcolorTip2;
            }
        }

    }
}
