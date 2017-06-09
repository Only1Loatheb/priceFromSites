using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promocjaAsus
{
    class LinkMobo
    {
        public string url { get; }
        public Mobo name { get; }

        public LinkMobo(string l, Mobo n)
        {
            url = l;
            name = n;
        }
    }
    class LinksMorele
    {
        public List<LinkMobo> moboLinks = new List<LinkMobo>();
        public List<string> ram16GBDualDifferentSpeed = new List<string>();
        public LinksMorele()
        {
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-prime-z270-p-z270-ddr4-hdmi-dvi-d-atx-975897/", Mobo.PRIME_Z270_P));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-prime-z270-k-z270-ddr4-hdmi-dvi-vga-atx-975896/", Mobo.PRIME_Z270_K));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-tuf-z270-mark-2-z270-ddr4-hdmi-dvi-atx-975894/", Mobo.TUF_Z270_MARK_2));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-prime-z270-a-z270-ddr4-hdmi-displayport-atx-975891/", Mobo.PRIME_Z270_A));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-strix-z270i-gaming-z270-ddr4-sata3-displayport-hdmi-miniitx-1128883/", Mobo.STRIX_Z270I_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-strix-z270h-gaming-z270-ddr4-hdmi-dvi-atx-975893/", Mobo.STRIX_Z270H_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-strix-z270f-gaming-z270-ddr4-hdmi-displayport-atx-975890/", Mobo.STRIX_Z270F_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-asus-strix-z270g-gaming-z270-ddr4-hdmi-displayport-matx-975889/", Mobo.STRIX_Z270G_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-strix-z270e-gaming-z270e-ddr4-hdmi-dvi-usb-c-atx-975888/", Mobo.STRIX_Z270E_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-tuf-z270-mark-1-z270-ddr4-hdmi-displayport-atx-975887/", Mobo.TUF_Z270_MARK_1));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170-ws-z170-ddr4-sata3-usb-3-1-atx-845548/", Mobo.Z170_WS));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170m-e-d3-z170-ddr3-sata3-usb-3-0-microatx-90mb0mr0-m0eay0-858844/", Mobo.Z170M_E_D3));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170-e-z170-ddr4-sata3-usb-3-1-atx-90mb0p60-m0eay0-817097/", Mobo.Z170_E));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-asus-z170-a-z170-quadddr4-2133-satae-sata3-hdmi-dvi-dp-usb-3-1-atx-z170-a-707314/", Mobo.Z170_A));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170-pro-gaming-z170-quadddr4-2133-sata3-hdmi-dvi-dp-usb-3-1-atx-707313/", Mobo.Z170_PRO_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170-pro-gaming-aura-z170-ddr4-sata3-usb-3-1-atx-90mb0s00-m0eay0-981399/", Mobo.Z170_PRO_GAMING_AURA));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170i-pro-gaming-z170-ddr4-sata3-usb-3-1-mini-itx-90mb0mq0-m0eay0-789607/", Mobo.Z170I_PRO_GAMING));
            moboLinks.Add(new LinkMobo("https://www.morele.net/plyta-glowna-asus-z170-deluxe-z170-quadddr4-2133-satae-sata3-hdmi-dp-usb-3-1-atx-z170-deluxe-764505/", Mobo.Z170_DELUXE));

            ram16GBDualDifferentSpeed.Add("https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O454598,21239O665142/1/");
            ram16GBDualDifferentSpeed.Add("https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O454598,7973O423807,21239O665142/1/");
            ram16GBDualDifferentSpeed.Add("https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O454598,7973O651898,21239O665142/1/");
            ram16GBDualDifferentSpeed.Add("https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O454598,7973O744203,21239O665142/1/");
            ram16GBDualDifferentSpeed.Add("https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O454598,7973O811795,21239O665142/1/");
            ram16GBDualDifferentSpeed.Add("https://www.morele.net/komputery/podzespoly-komputerowe/pamieci-ram-38/,,,,,,,p,0,,7965O980523,7971O454598,7973O928724.1031905.1031956.993473.1051230.1054072.1054075.1077954.1011132.1058534,21239O665142/1/");
    
        }

    }
}
