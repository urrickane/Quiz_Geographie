using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Permissions;

namespace Projet___Quiz_Géo_v3
{
    public partial class FrmMain : Form
    {
        float TotalQus;
        float Score = 0;
        int i = 1;
        int Pourcentage;
        List<RadioButton> Elements_Geo;
        string[] Liste_Elements_Geo;
        Label Lbl_Question;
        Label Lbl_Verif;

        //Création Liste
        List<RadioButton> EtatsEU = new List<RadioButton>();
        List<RadioButton> VillesEU = new List<RadioButton>();
        List<RadioButton> PaysAmerSud = new List<RadioButton>();
        List<RadioButton> CapitalesAmerSud = new List<RadioButton>();
        List<RadioButton> PaysEurope = new List<RadioButton>();
        List<RadioButton> CapitalesEurope = new List<RadioButton>();
        List<RadioButton> PaysAfrique = new List<RadioButton>();
        List<RadioButton> CapitalesAfrique = new List<RadioButton>();
        List<RadioButton> PaysAsie = new List<RadioButton>();
        List<RadioButton> CapitalesAsie = new List<RadioButton>();
        List<RadioButton> PaysOceanie = new List<RadioButton>();
        List<RadioButton> CapitalesOceanie = new List<RadioButton>();

        private void Crea_Quiz(float Nb_Qus, List<RadioButton> Elem_Geo, string[] Liste_Elem_Geo, Label Lbl_Qu, Label Lbl_Verification)
        {
            TotalQus = Nb_Qus;
            Elements_Geo = Elem_Geo;
            Liste_Elements_Geo = Liste_Elem_Geo;
            Lbl_Question = Lbl_Qu;
            Lbl_Verif = Lbl_Verification;
            i = 1;

            Lbl_Question.Text = "Cliquez sur " + Liste_Elements_Geo[i - 1];
        }

        private void Check_Answer(object sender, EventArgs e)
        {
            var BoutonSel = (RadioButton)sender;
            
            if(BoutonSel.TabIndex == i)
            {
                Score++;
                Lbl_Verif.Text = "Bonne réponse !";
            }
            else
            {
                Lbl_Verif.Text = "Mauvaise réponse.";
            }

            if (i == TotalQus)
            {
                Pourcentage = (int)((Score / TotalQus) * 100);

                Lbl_Question.Text = "Vous avez " + Score + " bonne(s) réponse(s) sur " + TotalQus + ", soit " + Pourcentage + "%.";
                Lbl_Verif.Text = "Bien joué!";
                Score = 0;
                i = 0;
            }

            if(i != 0)
            {
                i++;
                Lbl_Question.Text = "Cliquez sur " + Liste_Elements_Geo[i - 1];
            }
        }

            //Frame Main

            public FrmMain()
        {
            InitializeComponent();

            //Ajouter éléments à la liste Etats Amérique Nord
            EtatsEU.Add(BtnAmerNordEtatsAlabama);
            EtatsEU.Add(BtnAmerNordEtatsAlaska);
            EtatsEU.Add(BtnAmerNordEtatsArizona);
            EtatsEU.Add(BtnAmerNordEtatsArkansas);
            EtatsEU.Add(BtnAmerNordEtatsCalifornie);
            EtatsEU.Add(BtnAmerNordEtatsCarolineNord);
            EtatsEU.Add(BtnAmerNordEtatsCarolineSud);
            EtatsEU.Add(BtnAmerNordEtatsColorado);
            EtatsEU.Add(BtnAmerNordEtatsConnecticut);
            EtatsEU.Add(BtnAmerNordEtatsDakotaNord);
            EtatsEU.Add(BtnAmerNordEtatsDakotaSud);
            EtatsEU.Add(BtnAmerNordEtatsDelaware);
            EtatsEU.Add(BtnAmerNordEtatsFloride);
            EtatsEU.Add(BtnAmerNordEtatsGéorgie);
            EtatsEU.Add(BtnAmerNordEtatsHawai);
            EtatsEU.Add(BtnAmerNordEtatsIdaho);
            EtatsEU.Add(BtnAmerNordEtatsIllinois);
            EtatsEU.Add(BtnAmerNordEtatsIndiana);
            EtatsEU.Add(BtnAmerNordEtatsIowa);
            EtatsEU.Add(BtnAmerNordEtatsKansas);
            EtatsEU.Add(BtnAmerNordEtatsKentucky);
            EtatsEU.Add(BtnAmerNordEtatsLouisiane);
            EtatsEU.Add(BtnAmerNordEtatsMaine);
            EtatsEU.Add(BtnAmerNordEtatsMaryland);
            EtatsEU.Add(BtnAmerNordEtatsMassachusetts);
            EtatsEU.Add(BtnAmerNordEtatsMichigan);
            EtatsEU.Add(BtnAmerNordEtatsMinnesota);
            EtatsEU.Add(BtnAmerNordEtatsMississippi);
            EtatsEU.Add(BtnAmerNordEtatsMissouri);
            EtatsEU.Add(BtnAmerNordEtatsMontana);
            EtatsEU.Add(BtnAmerNordEtatsNebraska);
            EtatsEU.Add(BtnAmerNordEtatsNevada);
            EtatsEU.Add(BtnAmerNordEtatsNewHampshire);
            EtatsEU.Add(BtnAmerNordEtatsNewJersey);
            EtatsEU.Add(BtnAmerNordEtatsNewYork);
            EtatsEU.Add(BtnAmerNordEtatsNouveauMexique);
            EtatsEU.Add(BtnAmerNordEtatsOhio);
            EtatsEU.Add(BtnAmerNordEtatsOklahoma);
            EtatsEU.Add(BtnAmerNordEtatsOregon);
            EtatsEU.Add(BtnAmerNordEtatsPennsylvanie);
            EtatsEU.Add(BtnAmerNordEtatsRhodeIsland);
            EtatsEU.Add(BtnAmerNordEtatsTennessee);
            EtatsEU.Add(BtnAmerNordEtatsTexas);
            EtatsEU.Add(BtnAmerNordEtatsUtah);
            EtatsEU.Add(BtnAmerNordEtatsVermont);
            EtatsEU.Add(BtnAmerNordEtatsVirginie);
            EtatsEU.Add(BtnAmerNordEtatsVirginieOccidentale);
            EtatsEU.Add(BtnAmerNordEtatsWashington);
            EtatsEU.Add(BtnAmerNordEtatsWisconsin);
            EtatsEU.Add(BtnAmerNordEtatsWyoming);

            //Ajouter éléments à la liste Viiles Amérique Nord
            VillesEU.Add(BtnAmerNordVilleAlbuquerque);
            VillesEU.Add(BtnAmerNordVilleAtlanta);
            VillesEU.Add(BtnAmerNordVilleAustin);
            VillesEU.Add(BtnAmerNordVilleBaltimore);
            VillesEU.Add(BtnAmerNordVilleBirmingham);
            VillesEU.Add(BtnAmerNordVilleBoise);
            VillesEU.Add(BtnAmerNordVilleBoston);
            VillesEU.Add(BtnAmerNordVilleBuffalo);
            VillesEU.Add(BtnAmerNordVilleCharlotte);
            VillesEU.Add(BtnAmerNordVilleChicago);
            VillesEU.Add(BtnAmerNordVilleCincinnati);
            VillesEU.Add(BtnAmerNordVilleCleveland);
            VillesEU.Add(BtnAmerNordVilleDallas);
            VillesEU.Add(BtnAmerNordVilleDenver);
            VillesEU.Add(BtnAmerNordVilleDétroit);
            VillesEU.Add(BtnAmerNordVilleElPaso);
            VillesEU.Add(BtnAmerNordVilleHonolulu);
            VillesEU.Add(BtnAmerNordVilleHouston);
            VillesEU.Add(BtnAmerNordVilleIndianapolis);
            VillesEU.Add(BtnAmerNordVilleJacksonville);
            VillesEU.Add(BtnAmerNordVilleJuneau);
            VillesEU.Add(BtnAmerNordVilleKansasCity);
            VillesEU.Add(BtnAmerNordVilleLaNouvelleOrléans);
            VillesEU.Add(BtnAmerNordVilleLasVegas);
            VillesEU.Add(BtnAmerNordVilleLosAngeles);
            VillesEU.Add(BtnAmerNordVilleMemphis);
            VillesEU.Add(BtnAmerNordVilleMiami);
            VillesEU.Add(BtnAmerNordVilleMilwaukee);
            VillesEU.Add(BtnAmerNordVilleMinneapolis);
            VillesEU.Add(BtnAmerNordVilleMobile);
            VillesEU.Add(BtnAmerNordVilleNashville);
            VillesEU.Add(BtnAmerNordVilleNewYork);
            VillesEU.Add(BtnAmerNordVilleOklahomaCity);
            VillesEU.Add(BtnAmerNordVilleOmaha);
            VillesEU.Add(BtnAmerNordVillePhiladelphie);
            VillesEU.Add(BtnAmerNordVillePhoenix);

            //Ajouter éléments à la liste Pays Amérique Sud
            PaysAmerSud.Add(BtnAmerSudPaysArgentine);
            PaysAmerSud.Add(BtnAmerSudPaysBolivie);
            PaysAmerSud.Add(BtnAmerSudPaysBrésil);
            PaysAmerSud.Add(BtnAmerSudPaysChili);
            PaysAmerSud.Add(BtnAmerSudPaysColombie);
            PaysAmerSud.Add(BtnAmerSudPaysEquateur);
            PaysAmerSud.Add(BtnAmerSudPaysGuyana);
            PaysAmerSud.Add(BtnAmerSudPaysGuyaneFrançaise);
            PaysAmerSud.Add(BtnAmerSudPaysParaguay);
            PaysAmerSud.Add(BtnAmerSudPaysPérou);
            PaysAmerSud.Add(BtnAmerSudPaysSuriname);
            PaysAmerSud.Add(BtnAmerSudPaysUruguay);
            PaysAmerSud.Add(BtnAmerSudPaysVenezuela);

            //Ajouter éléments à la liste Capitale Amérique Sud
            CapitalesAmerSud.Add(BtnAmerSudCapitaleAsuncion);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleBogota);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleBrasilia);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleBuenosAires);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleCaracas);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleGeorgetown);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleLima);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleMontevideo);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleParamaribo);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleQuito);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleSantiagoDuChili);
            CapitalesAmerSud.Add(BtnAmerSudCapitaleSucre);

            //Ajouter éléments à la liste Pays Europe
            PaysEurope.Add(BtnEuropePaysSuisse);
            PaysEurope.Add(BtnEuropePaysLuxembourg);
            PaysEurope.Add(BtnEuropePaysNorvège);
            PaysEurope.Add(BtnEuropePaysSuède);
            PaysEurope.Add(BtnEuropePaysDanemark);
            PaysEurope.Add(BtnEuropePaysAllemagne);
            PaysEurope.Add(BtnEuropePaysBelgique);
            PaysEurope.Add(BtnEuropePaysBas);
            PaysEurope.Add(BtnEuropePaysAndorre);
            PaysEurope.Add(BtnEuropePaysPortugal);
            PaysEurope.Add(BtnEuropePaysEspagne);
            PaysEurope.Add(BtnEuropePaysFrance);
            PaysEurope.Add(BtnEuropePaysIrlande);
            PaysEurope.Add(BtnEuropePaysRoyaumeUni);
            PaysEurope.Add(BtnEuropePaysIslande);
            PaysEurope.Add(BtnEuropePaysMonaco);
            PaysEurope.Add(BtnEuropePaysLiechtenstein);
            PaysEurope.Add(BtnEuropePaysGrèce);
            PaysEurope.Add(BtnEuropePaysBulgarie);
            PaysEurope.Add(BtnEuropePaysMacédoineNord);
            PaysEurope.Add(BtnEuropePaysAlbanie);
            PaysEurope.Add(BtnEuropePaysKosovo);
            PaysEurope.Add(BtnEuropePaysMonténégro);
            PaysEurope.Add(BtnEuropePaysSerbie);
            PaysEurope.Add(BtnEuropePaysBosnieHerzégovine);
            PaysEurope.Add(BtnEuropePaysCroatie);
            PaysEurope.Add(BtnEuropePaysRoumanie);
            PaysEurope.Add(BtnEuropePaysSlovénie);
            PaysEurope.Add(BtnEuropePaysHongrie);
            PaysEurope.Add(BtnEuropePaysAutriche);
            PaysEurope.Add(BtnEuropePaysSlovaquie);
            PaysEurope.Add(BtnEuropePaysMoldavie);
            PaysEurope.Add(BtnEuropePaysUkraine);
            PaysEurope.Add(BtnEuropePaysBiélorussie);
            PaysEurope.Add(BtnEuropePaysRussie);
            PaysEurope.Add(BtnEuropePaysFinlande);
            PaysEurope.Add(BtnEuropePaysTchéquie);
            PaysEurope.Add(BtnEuropePaysPologne);
            PaysEurope.Add(BtnEuropePaysLituanie);
            PaysEurope.Add(BtnEuropePaysLettonie);
            PaysEurope.Add(BtnEuropePaysEstonie);
            PaysEurope.Add(BtnEuropePaysVatican);
            PaysEurope.Add(BtnEuropePaysSaintMarin);
            PaysEurope.Add(BtnEuropePaysItalie);


            //Ajouter éléments à la liste Capitales Europe
            CapitalesEurope.Add(BtnEuropeCapitaleAthènes);
            CapitalesEurope.Add(BtnEuropeCapitaleRome);
            CapitalesEurope.Add(BtnEuropeCapitaleLisbonne);
            CapitalesEurope.Add(BtnEuropeCapitaleMadrid);
            CapitalesEurope.Add(BtnEuropeCapitaleAndorreLaVieille);
            CapitalesEurope.Add(BtnEuropeCapitaleMonaco);
            CapitalesEurope.Add(BtnEuropeCapitaleSaintMarin);
            CapitalesEurope.Add(BtnEuropeCapitaleTirana);
            CapitalesEurope.Add(BtnEuropeCapitalePodgorica);
            CapitalesEurope.Add(BtnEuropeCapitaleSkopje);
            CapitalesEurope.Add(BtnEuropeCapitalePristina);
            CapitalesEurope.Add(BtnEuropeCapitaleSofia);
            CapitalesEurope.Add(BtnEuropeCapitaleBucarest);
            CapitalesEurope.Add(BtnEuropeCapitaleBelgrade);
            CapitalesEurope.Add(BtnEuropeCapitaleSarajevo);
            CapitalesEurope.Add(BtnEuropeCapitaleZagreb);
            CapitalesEurope.Add(BtnEuropeCapitaleLjubljana);
            CapitalesEurope.Add(BtnEuropeCapitaleChisinau);
            CapitalesEurope.Add(BtnEuropeCapitaleBudapest);
            CapitalesEurope.Add(BtnEuropeCapitaleBratislava);
            CapitalesEurope.Add(BtnEuropeCapitaleVienne);
            CapitalesEurope.Add(BtnEuropeCapitaleVaduz);
            CapitalesEurope.Add(BtnEuropeCapitaleBerne);
            CapitalesEurope.Add(BtnEuropeCapitaleParis);
            CapitalesEurope.Add(BtnEuropeCapitaleKiev);
            CapitalesEurope.Add(BtnEuropeCapitalePrague);
            CapitalesEurope.Add(BtnEuropeCapitaleLuxembourg);
            CapitalesEurope.Add(BtnEuropeCapitaleBruxelles);
            CapitalesEurope.Add(BtnEuropeCapitaleMinsk);
            CapitalesEurope.Add(BtnEuropeCapitaleVarsovie);
            CapitalesEurope.Add(BtnEuropeCapitaleBerlin);
            CapitalesEurope.Add(BtnEuropeCapitaleDublin);
            CapitalesEurope.Add(BtnEuropeCapitaleLondres);
            CapitalesEurope.Add(BtnEuropeCapitaleAmsterdam);
            CapitalesEurope.Add(BtnEuropeCapitaleCopenhague);
            CapitalesEurope.Add(BtnEuropeCapitaleVilnius);
            CapitalesEurope.Add(BtnEuropeCapitaleMoscou);
            CapitalesEurope.Add(BtnEuropeCapitaleRiga);
            CapitalesEurope.Add(BtnEuropeCapitaleTallinn);
            CapitalesEurope.Add(BtnEuropeCapitaleHelsinki);
            CapitalesEurope.Add(BtnEuropeCapitaleStockholm);
            CapitalesEurope.Add(BtnEuropeCapitaleOslo);
            CapitalesEurope.Add(BtnEuropeCapitaleReykjavik);

            //Ajouter éléments à la liste Pays Afrique
            PaysAfrique.Add(BtnAfriquePaysDjibouti);
            PaysAfrique.Add(BtnAfriquePaysLesotho);
            PaysAfrique.Add(BtnAfriquePaysEswatini);
            PaysAfrique.Add(BtnAfriquePaysRépubliqueDémocratiqueCongo);
            PaysAfrique.Add(BtnAfriquePaysMaurice);
            PaysAfrique.Add(BtnAfriquePaysMadagascar);
            PaysAfrique.Add(BtnAfriquePaysMalawi);
            PaysAfrique.Add(BtnAfriquePaysMozambique);
            PaysAfrique.Add(BtnAfriquePaysBotswana);
            PaysAfrique.Add(BtnAfriquePaysZimbabwe);
            PaysAfrique.Add(BtnAfriquePaysNamibie);
            PaysAfrique.Add(BtnAfriquePaysZambie);
            PaysAfrique.Add(BtnAfriquePaysAngola);
            PaysAfrique.Add(BtnAfriquePaysComores);
            PaysAfrique.Add(BtnAfriquePaysSeychelles);
            PaysAfrique.Add(BtnAfriquePaysTanzanie);
            PaysAfrique.Add(BtnAfriquePaysBurundi);
            PaysAfrique.Add(BtnAfriquePaysRwanda);
            PaysAfrique.Add(BtnAfriquePaysKenya);
            PaysAfrique.Add(BtnAfriquePaysOuganda);
            PaysAfrique.Add(BtnAfriquePaysAfriqueSud);
            PaysAfrique.Add(BtnAfriquePaysCongo);
            PaysAfrique.Add(BtnAfriquePaysGabon);
            PaysAfrique.Add(BtnAfriquePaysSaoToméEtPrincipe);
            PaysAfrique.Add(BtnAfriquePaysGuinéeEquatoriale);
            PaysAfrique.Add(BtnAfriquePaysSomalie);
            PaysAfrique.Add(BtnAfriquePaysErythrée);
            PaysAfrique.Add(BtnAfriquePaysEthiopie);
            PaysAfrique.Add(BtnAfriquePaysSoudanSud);
            PaysAfrique.Add(BtnAfriquePaysRépubliqueCentrafricaine);
            PaysAfrique.Add(BtnAfriquePaysCameroun);
            PaysAfrique.Add(BtnAfriquePaysNigeria);
            PaysAfrique.Add(BtnAfriquePaysGambie);
            PaysAfrique.Add(BtnAfriquePaysGuinéeBissau);
            PaysAfrique.Add(BtnAfriquePaysSierraLeone);
            PaysAfrique.Add(BtnAfriquePaysGuinée);
            PaysAfrique.Add(BtnAfriquePaysLiberia);
            PaysAfrique.Add(BtnAfriquePaysCôteIvoire);
            PaysAfrique.Add(BtnAfriquePaysGhana);
            PaysAfrique.Add(BtnAfriquePaysBénin);
            PaysAfrique.Add(BtnAfriquePaysTogo);
            PaysAfrique.Add(BtnAfriquePaysBurkinaFaso);
            PaysAfrique.Add(BtnAfriquePaysSénégal);
            PaysAfrique.Add(BtnAfriquePaysCapVert);
            PaysAfrique.Add(BtnAfriquePaysSaharaOccidental);
            PaysAfrique.Add(BtnAfriquePaysMauritanie);
            PaysAfrique.Add(BtnAfriquePaysMali);
            PaysAfrique.Add(BtnAfriquePaysNiger);
            PaysAfrique.Add(BtnAfriquePaysTchad);
            PaysAfrique.Add(BtnAfriquePaysSoudan);
            PaysAfrique.Add(BtnAfriquePaysEgypte);
            PaysAfrique.Add(BtnAfriquePaysLibye);
            PaysAfrique.Add(BtnAfriquePaysTunisie);
            PaysAfrique.Add(BtnAfriquePaysAlgérie);
            PaysAfrique.Add(BtnAfriquePaysMaroc);

            //Ajouter éléments à la liste Capitales Afrique
            CapitalesAfrique.Add(BtnAfriqueCapitalePraia);
            CapitalesAfrique.Add(BtnAfriqueCapitaleSaoTomé);
            CapitalesAfrique.Add(BtnAfriqueCapitalePortLouis);
            CapitalesAfrique.Add(BtnAfriqueCapitaleVictoria);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMoroni);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMaputo);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMbabane);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMaseru);
            CapitalesAfrique.Add(BtnAfriqueCapitalePretoria);
            CapitalesAfrique.Add(BtnAfriqueCapitaleGaborone);
            CapitalesAfrique.Add(BtnAfriqueCapitaleWindhoek);
            CapitalesAfrique.Add(BtnAfriqueCapitaleHarare);
            CapitalesAfrique.Add(BtnAfriqueCapitaleTananarive);
            CapitalesAfrique.Add(BtnAfriqueCapitaleLilongwe);
            CapitalesAfrique.Add(BtnAfriqueCapitaleLusaka);
            CapitalesAfrique.Add(BtnAfriqueCapitaleLuanda);
            CapitalesAfrique.Add(BtnAfriqueCapitaleDodoma);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMogadiscio);
            CapitalesAfrique.Add(BtnAfriqueCapitaleNairobi);
            CapitalesAfrique.Add(BtnAfriqueCapitaleGitega);
            CapitalesAfrique.Add(BtnAfriqueCapitaleKigali);
            CapitalesAfrique.Add(BtnAfriqueCapitaleKampala);
            CapitalesAfrique.Add(BtnAfriqueCapitaleKinshasa);
            CapitalesAfrique.Add(BtnAfriqueCapitaleBrazzaville);
            CapitalesAfrique.Add(BtnAfriqueCapitaleLibreville);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMalabo);
            CapitalesAfrique.Add(BtnAfriqueCapitaleYaoundé);
            CapitalesAfrique.Add(BtnAfriqueCapitaleDjibouti);
            CapitalesAfrique.Add(BtnAfriqueCapitaleAddisAdeba);
            CapitalesAfrique.Add(BtnAfriqueCapitaleDjouba);
            CapitalesAfrique.Add(BtnAfriqueCapitaleBangui);
            CapitalesAfrique.Add(BtnAfriqueCapitaleNDjaména);
            CapitalesAfrique.Add(BtnAfriqueCapitaleAbuja);
            CapitalesAfrique.Add(BtnAfriqueCapitalePortoNovo);
            CapitalesAfrique.Add(BtnAfriqueCapitaleLomé);
            CapitalesAfrique.Add(BtnAfriqueCapitaleAccra);
            CapitalesAfrique.Add(BtnAfriqueCapitaleNiamey);
            CapitalesAfrique.Add(BtnAfriqueCapitaleOuagadougou);
            CapitalesAfrique.Add(BtnAfriqueCapitaleYamoussoukro);
            CapitalesAfrique.Add(BtnAfriqueCapitaleBamako);
            CapitalesAfrique.Add(BtnAfriqueCapitaleMonrovia);
            CapitalesAfrique.Add(BtnAfriqueCapitaleFreetown);
            CapitalesAfrique.Add(BtnAfriqueCapitaleConakry);
            CapitalesAfrique.Add(BtnAfriqueCapitaleBissau);
            CapitalesAfrique.Add(BtnAfriqueCapitaleBanjul);
            CapitalesAfrique.Add(BtnAfriqueCapitaleDakar);
            CapitalesAfrique.Add(BtnAfriqueCapitaleNouakchott);
            CapitalesAfrique.Add(BtnAfriqueCapitaleAsmara);
            CapitalesAfrique.Add(BtnAfriqueCapitaleKhartoum);
            CapitalesAfrique.Add(BtnAfriqueCapitaleLeCaire);
            CapitalesAfrique.Add(BtnAfriqueCapitaleTripoli);
            CapitalesAfrique.Add(BtnAfriqueCapitaleTunis);
            CapitalesAfrique.Add(BtnAfriqueCapitaleAlger);
            CapitalesAfrique.Add(BtnAfriqueCapitaleRabat);

            //Ajouter éléments à la liste Pays Asie
            PaysAsie.Add(BtnAsiePaysMaldives);
            PaysAsie.Add(BtnAsiePaysSriLanka);
            PaysAsie.Add(BtnAsiePaysTimorOriental);
            PaysAsie.Add(BtnAsiePaysPhilippines);
            PaysAsie.Add(BtnAsiePaysTaïwan);
            PaysAsie.Add(BtnAsiePaysCoréeNord);
            PaysAsie.Add(BtnAsiePaysQatar);
            PaysAsie.Add(BtnAsiePaysBahrein);
            PaysAsie.Add(BtnAsiePaysKoweit);
            PaysAsie.Add(BtnAsiePaysIsraël);
            PaysAsie.Add(BtnAsiePaysLiban);
            PaysAsie.Add(BtnAsiePaysTurquie);
            PaysAsie.Add(BtnAsiePaysIndonésie);
            PaysAsie.Add(BtnAsiePaysMalaisie);
            PaysAsie.Add(BtnAsiePaysBrunei);
            PaysAsie.Add(BtnAsiePaysSingapour);
            PaysAsie.Add(BtnAsiePaysCambodge);
            PaysAsie.Add(BtnAsiePaysViêtNam);
            PaysAsie.Add(BtnAsiePaysLaos);
            PaysAsie.Add(BtnAsiePaysThaïlande);
            PaysAsie.Add(BtnAsiePaysBirmanie);
            PaysAsie.Add(BtnAsiePaysBangladesh);
            PaysAsie.Add(BtnAsiePaysBhoutan);
            PaysAsie.Add(BtnAsiePaysNépal);
            PaysAsie.Add(BtnAsiePaysInde);
            PaysAsie.Add(BtnAsiePaysPakistan);
            PaysAsie.Add(BtnAsiePaysEmiratsArabesUnis);
            PaysAsie.Add(BtnAsiePaysOman);
            PaysAsie.Add(BtnAsiePaysYémen);
            PaysAsie.Add(BtnAsiePaysArabieSaoudite);
            PaysAsie.Add(BtnAsiePaysJordanie);
            PaysAsie.Add(BtnAsiePaysSyrie);
            PaysAsie.Add(BtnAsiePaysIrak);
            PaysAsie.Add(BtnAsiePaysIran);
            PaysAsie.Add(BtnAsiePaysAfghanistan);
            PaysAsie.Add(BtnAsiePaysTadjikistan);
            PaysAsie.Add(BtnAsiePaysArménie);
            PaysAsie.Add(BtnAsiePaysGéorgie);
            PaysAsie.Add(BtnAsiePaysAzerbaïdjan);
            PaysAsie.Add(BtnAsiePaysTurkménistan);
            PaysAsie.Add(BtnAsiePaysOuzbékistan);
            PaysAsie.Add(BtnAsiePaysKirghizistan);
            PaysAsie.Add(BtnAsiePaysJapon);
            PaysAsie.Add(BtnAsiePaysCoréeSud);
            PaysAsie.Add(BtnAsiePaysChine);
            PaysAsie.Add(BtnAsiePaysMongolie);
            PaysAsie.Add(BtnAsiePaysKazakhstan);
            PaysAsie.Add(BtnAsiePaysRussie);

            //Ajouter éléments à la liste Capitales Asie
            CapitalesAsie.Add(BtnAsieCapitaleMalé);
            CapitalesAsie.Add(BtnAsieCapitaleDili);
            CapitalesAsie.Add(BtnAsieCapitaleManille);
            CapitalesAsie.Add(BtnAsieCapitaleBandarSeriBegawan);
            CapitalesAsie.Add(BtnAsieCapitaleJakarta);
            CapitalesAsie.Add(BtnAsieCapitaleSingapour);
            CapitalesAsie.Add(BtnAsieCapitaleKualaLumpur);
            CapitalesAsie.Add(BtnAsieCapitaleSriJayawardenapuraKotte);
            CapitalesAsie.Add(BtnAsieCapitalePhnomPenh);
            CapitalesAsie.Add(BtnAsieCapitaleBangkok);
            CapitalesAsie.Add(BtnAsieCapitaleVientiane);
            CapitalesAsie.Add(BtnAsieCapitaleTaipei);
            CapitalesAsie.Add(BtnAsieCapitaleHanoi);
            CapitalesAsie.Add(BtnAsieCapitaleNaypyidaw);
            CapitalesAsie.Add(BtnAsieCapitaleDacca);
            CapitalesAsie.Add(BtnAsieCapitaleThimphou);
            CapitalesAsie.Add(BtnAsieCapitaleKatmandou);
            CapitalesAsie.Add(BtnAsieCapitaleNewDehli);
            CapitalesAsie.Add(BtnAsieCapitaleIslamabad);
            CapitalesAsie.Add(BtnAsieCapitaleKaboul);
            CapitalesAsie.Add(BtnAsieCapitaleMascate);
            CapitalesAsie.Add(BtnAsieCapitaleAbuDabi);
            CapitalesAsie.Add(BtnAsieCapitaleDoha);
            CapitalesAsie.Add(BtnAsieCapitaleManama);
            CapitalesAsie.Add(BtnAsieCapitaleTéhéran);
            CapitalesAsie.Add(BtnAsieCapitaleKoweït);
            CapitalesAsie.Add(BtnAsieCapitaleSanaa);
            CapitalesAsie.Add(BtnAsieCapitaleRiyad);
            CapitalesAsie.Add(BtnAsieCapitaleBagdad);
            CapitalesAsie.Add(BtnAsieCapitaleAmman);
            CapitalesAsie.Add(BtnAsieCapitaleJérusalem);
            CapitalesAsie.Add(BtnAsieCapitaleDamas);
            CapitalesAsie.Add(BtnAsieCapitaleBeyrouth);
            CapitalesAsie.Add(BtnAsieCapitaleAnkara);
            CapitalesAsie.Add(BtnAsieCapitaleErevan);
            CapitalesAsie.Add(BtnAsieCapitaleTbilissi);
            CapitalesAsie.Add(BtnAsieCapitaleBakou);
            CapitalesAsie.Add(BtnAsieCapitaleAchgabat);
            CapitalesAsie.Add(BtnAsieCapitaleDouchanbé);
            CapitalesAsie.Add(BtnAsieCapitaleTachkent);
            CapitalesAsie.Add(BtnAsieCapitaleTokyo);
            CapitalesAsie.Add(BtnAsieCapitaleSéoul);
            CapitalesAsie.Add(BtnAsieCapitalePyongyang);
            CapitalesAsie.Add(BtnAsieCapitalePékin);
            CapitalesAsie.Add(BtnAsieCapitaleBichkek);
            CapitalesAsie.Add(BtnAsieCapitaleOulanBator);
            CapitalesAsie.Add(BtnAsieCapitaleNoursoultan);

            //Ajouter éléments à la liste Pays Océanie
            PaysOceanie.Add(BtnOcéaniePaysAustralie);
            PaysOceanie.Add(BtnOcéaniePaysFidji);
            PaysOceanie.Add(BtnOcéaniePaysKiribati);
            PaysOceanie.Add(BtnOcéaniePaysMarshall);
            PaysOceanie.Add(BtnOcéaniePaysMicronésie);
            PaysOceanie.Add(BtnOcéaniePaysNouvelleZélande);
            PaysOceanie.Add(BtnOcéaniePaysPalaos);
            PaysOceanie.Add(BtnOcéaniePaysPapouasieNouvelleGuinée);
            PaysOceanie.Add(BtnOcéaniePaysSalomon);
            PaysOceanie.Add(BtnOcéaniePaysSamoa);
            PaysOceanie.Add(BtnOcéaniePaysTonga);
            PaysOceanie.Add(BtnOcéaniePaysTuvalu);
            PaysOceanie.Add(BtnOcéaniePaysVanuatu);

            //Ajouter éléments à la liste Capitales Océanie
            CapitalesOceanie.Add(BtnOcéanieCapitaleApia);
            CapitalesOceanie.Add(BtnOcéanieCapitaleCanberra);
            CapitalesOceanie.Add(BtnOcéanieCapitaleFunafuti);
            CapitalesOceanie.Add(BtnOcéanieCapitaleHoniara);
            CapitalesOceanie.Add(BtnOcéanieCapitaleMajuro);
            CapitalesOceanie.Add(BtnOcéanieCapitaleNgerulmud);
            CapitalesOceanie.Add(BtnOcéanieCapitaleNukuAlofa);
            CapitalesOceanie.Add(BtnOcéanieCapitalePalikir);
            CapitalesOceanie.Add(BtnOcéanieCapitalePortMoresby);
            CapitalesOceanie.Add(BtnOcéanieCapitalePortVila);
            CapitalesOceanie.Add(BtnOcéanieCapitaleSuva);
            CapitalesOceanie.Add(BtnOcéanieCapitaleTarawaSud);
            CapitalesOceanie.Add(BtnOcéanieCapitaleWellington);
            CapitalesOceanie.Add(BtnOcéanieCapitaleYaren);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Location = new Point(0, 0);
            PnlChxCarte.Visible = true;
        }

        //Panel Choix Cartes (1850;0)

        private void BtnChxCarteAmerNord_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerNord.Location = new Point(0,0);
            PnlChxCarteAmerNord.Visible = true;
            PnlChxCarte.Visible = false;

        }

        private void BtnChxCarteAmerSud_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerSud.Location = new Point(0, 0);
            PnlChxCarteAmerSud.Visible = true;
            PnlChxCarte.Visible = false;
        }

        private void BtnChxCarteEurope_Click(object sender, EventArgs e)
        {
            PnlChxCarteEurope.Location = new Point(0, 0);
            PnlChxCarteEurope.Visible = true;
            PnlChxCarte.Visible = false;
        }

        private void BtnChxCarteAfrique_Click(object sender, EventArgs e)
        {
            PnlChxCarteAfrique.Location = new Point(0, 0);
            PnlChxCarteAfrique.Visible = true;
            PnlChxCarte.Visible = false;
        }

        private void BtnChxCarteAsie_Click(object sender, EventArgs e)
        {
            PnlChxCarteAsie.Location = new Point(0, 0);
            PnlChxCarteAsie.Visible = true;
            PnlChxCarte.Visible = false;
        }

        private void BtnChxCarteOceanie_Click(object sender, EventArgs e)
        {
            PnlChxCarteOcéanie.Location = new Point(0, 0);
            PnlChxCarteOcéanie.Visible = true;
            PnlChxCarte.Visible = false;
        }

        private void BtnCancelChxCarte_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = false;
        }

        //Panel Choix Carte Amérique Nord (1850;20)

        private void BtnChxCarteAmerNordEtats_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerNordEtats.Location = new Point(0, 0);
            PnlChxCarteAmerNordEtats.Visible = true;
            PnlChxCarteAmerNord.Visible = false;

            string[] Liste_Etats_EU = { "Alabama", "Alaska", "Arizona", "Arkansas", "Californie", "Caroline du Nord", "Caroline du Sud", "Colorado", "Connecticut", "Dakota du Nord", "Dakota du Sud", "Delaware", "Floride", "Georgie", "Hawai", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiane", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New York", "Nouveau-Mexique", "Ohio", "Oklahoma", "Oregon", "Pennsylvanie", "Rhode Island", "Tennessee", "Texas", "Utah", "Vermont", "Virginie", "Virginie-Occidentale", "Washington", "Wisconsin", "Wyoming" };
            Crea_Quiz(50, EtatsEU, Liste_Etats_EU, LblQuEUEtats, LblVerifEUEtats);

            for (int i = 0; i < 50; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnChxAmerNordVilles_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerNordVilles.Location = new Point(0, 0);
            PnlChxCarteAmerNordVilles.Visible = true;
            PnlChxCarteAmerNord.Visible = false;

            string[] Liste_Villes_EU = { "Albuquerque", "Atlanta", "Austin", "Baltimore", "Birmingham", "Boise", "Boston", "Buffalo", "Charlotte", "Chicago", "Cincinnati", "Cleveland", "Dallas", "Denver", "Detroit", "El Paso", "Honolulu", "Houston", "Indianapolis", "Jacksonville", "Juneau", "Kansas City", "La Nouvelle - Orleans", "Las Vegas", "Los Angeles", "Memphis", "Miami", "Milwaukee", "Minneapolis", "Mobile", "Nashville", "New York", "Oklahoma City", "Omaha", "Philadelphie", "Phoenix", "Pittsburgh", "Portland", "Richmond", "Saint Paul", "Saint - Louis", "Salt Lake City", "San Antonio", "San Diego", "San Francisco", "San Jose", "Seattle", "Tampa", "Toledo", "Tucson", "Tulsa", "Washington DC", "Wichita" };
            Crea_Quiz(53, VillesEU, Liste_Villes_EU, LblQuEUVilles, LblVerifEUVilles);

            for (int i = 0; i < 53; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnCancelChxCarteAmerNord_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = true;
            PnlChxCarteAmerNord.Visible = false;
        }

        //Panel Choix Carte Amérique Nord Etats (1850;40)
        
        private void BtnCancelChxCarteAmerNordEtats_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerNord.Visible = true;
            PnlChxCarteAmerNordEtats.Visible = false;
        }

        //Panel Choix Carte Amérique Nord Villes (1850;60)

        private void BtnCancelChxCarteAmerNordVilles_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerNord.Visible = true;
            PnlChxCarteAmerNordVilles.Visible = false;
        }

        //Panel Choix Carte Amérique Sud (1850;80)

        private void BtnChoixCarteAmerSudPays_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerSudPays.Location = new Point(0, 0);
            PnlChxCarteAmerSudPays.Visible = true;
            PnlChxCarteAmerSud.Visible = false;

            string[] Liste_Pays_AmerSud = { "Argentine", "Bolivie", "Bresil", "Chili", "Colombie", "Equateur", "Guyana", "Guyane Francaise", "Paraguay", "Perou", "Suriname", "Uruguay", "Venezuela" };
            Crea_Quiz(13, PaysAmerSud, Liste_Pays_AmerSud, LblQuPaysAmerSud, LblVerifAmerSudPays);

            for(int i = 0; i < 13; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnChxCarteAmerSudCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerSudCapitales.Location = new Point(0, 0);
            PnlChxCarteAmerSudCapitales.Visible = true;
            PnlChxCarteAmerSud.Visible = false;

            string[] Liste_Capitales_AmerSud = { "Asuncion", "Bogota", "Brasilia", "Buenos Aires", "Caracas", "Georgetown", "Lima", "Montevideo", "Paramaribo", "Quito", "Santiago du Chili", "Sucre" };
            Crea_Quiz(12, CapitalesAmerSud, Liste_Capitales_AmerSud, LblQuCapitalesAmerSud, LblVerifAmerSudCapitales);

            for (int i = 0; i < 12; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnCancelChxCarteAmerSud_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = true;
            PnlChxCarteAmerSud.Visible = false;
        }

        //Panel Choix Carte Amérique Sud Pays (1850;100)

        private void BtnCancelChxCarteAmerSudPays_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerSud.Visible = true;
            PnlChxCarteAmerSudPays.Visible = false;
        }

        //Panel Choix Carte Amérique Sud Capitales (1850;120)

        private void BtnCancelChxCarteAmerSudCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteAmerSud.Visible = true;
            PnlChxCarteAmerSudCapitales.Visible = false;
        }

        //Panel Choix Carte Europe (1850;140)

        private void BtnChxCarteEuropePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteEuropePays.Location = new Point(0, 0);
            PnlChxCarteEuropePays.Visible = true;
            PnlChxCarteEurope.Visible = false;

            string[] Liste_Pays_Europe = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie-Herzégovine", "Bulgarie", "Croatie", "Danemark", "Espagne", "Estonie", "Finlande", "France", "Grèce", "Hongrie", "Irlande", "Islande", "Italie", "Kosovo", "Lettonie", "Liechtenstein", "Lituanie", "Luxembourg", "Macédoine du Nord", "Moldavie", "Monaco", "Monténégro", "Norvège", "Pays-Bas", "Pologne", "Portugal", "Roumanie", "Royaume-Uni", "Russie", "Saint-Marin", "Serbie", "Slovaquie", "Slovénie", "Suède", "Suisse", "Tchéquie", "Ukraine", "Vatican" };
            Crea_Quiz(44, PaysEurope, Liste_Pays_Europe, LblQuPaysEurope, LblVerifEuropePays);

            for (int i = 0; i < 44; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnChxCarteEuropeCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteEuropeCapitales.Location = new Point(0, 0);
            PnlChxCarteEuropeCapitales.Visible = true;
            PnlChxCarteEurope.Visible = false;

            string[] Liste_Capitales_Europe = { "Amsterdam", "Andorre-la-Vieille", "Athènes", "Belgrade", "Berlin", "Berne", "Bratislava", "Bruxelles", "Bucarest", "Budapest", "Chișinău", "Copenhague", "Dublin", "Helsinki", "Kiev", "Lisbonne", "Ljubljana", "Londres", "Luxembourg", "Madrid", "Minsk", "Monaco", "Moscou", "Oslo", "Paris", "Podgorica", "Prague", "Pristina", "Reykjavik", "Riga", "Rome", "Saint-Marin", "Sarajevo", "Skopje", "Sofia", "Stockholm", "Tallinn", "Tirana", "Vaduz", "Varsovie", "Vienne", "Vilnius", "Zagreb" };
            Crea_Quiz(43, CapitalesEurope, Liste_Capitales_Europe, LblQuEuropeCapitales, LblVerifEuropeCapitales);

            for (int i = 0; i < 43; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnCancelChxCarteEurope_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = true;
            PnlChxCarteEurope.Visible = false;
        }

        //Panel Choix Carte Europe Pays (1850;160)

        private void BtnCancelChxCarteEuropePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteEurope.Visible = true;
            PnlChxCarteEuropePays.Visible = false;
        }

        //Panel Choix Carte Europe Capitales (1850;180)

        private void BtnCancelChxCarteEuropeCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteEurope.Visible = true;
            PnlChxCarteEuropeCapitales.Visible = false;
        }

        //Panel Choix Carte Afrique (1850;200)

        private void BtnChxCarteAfriquePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteAfriquePays.Location = new Point(0, 0);
            PnlChxCarteAfriquePays.Visible = true;
            PnlChxCarteAfrique.Visible = false;

            string[] Liste_Pays_Afrique = { "Afrique du Sud", "Algérie", "Angola", "Bénin", "Botswana", "Burkina Faso", "Burundi", "Cameroun", "Cap-Vert", "Comores", "Congo", "Côte d’Ivoire", "Djibouti", "Égypte", "Érythrée", "Eswatini", "Éthiopie", "Gabon", "Gambie", "Ghana", "Guinée", "Guinée équatoriale", "Guinée-Bissau", "Kenya", "Lesotho", "Liberia", "Libye", "Madagascar", "Malawi", "Mali", "Maroc", "Maurice", "Mauritanie", "Mozambique", "Namibie", "Niger", "Nigeria", "Ouganda", "République Centrafricaine", "République démocratique du Congo", "Rwanda", "Sahara occidental", "Sao Tomé-et-Principe", "Sénégal", "Seychelles", "Sierra Leone", "Somalie", "Soudan", "Soudan du Sud", "Tanzanie", "Tchad", "Togo", "Tunisie", "Zambie", "Zimbabwe" };
            Crea_Quiz(55, PaysAfrique, Liste_Pays_Afrique, LblQuAfriquePays, LblVerifAfriquePays);

            for (int i = 0; i < 55; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnChxCarteAfriqueCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteAfriqueCapitales.Location = new Point(0, 0);
            PnlChxCarteAfriqueCapitales.Visible = true;
            PnlChxCarteAfrique.Visible = false;

            string[] Liste_Capitales_Afrique = { "Abuja", "Accra", "Addis-Abeba", "Alger", "Asmara", "Bamako", "Bangui", "Banjul", "Bissau", "Brazzaville", "Conakry", "Dakar", "Djibouti", "Djouba", "Dodoma", "Freetown", "Gaborone", "Gitega", "Harare", "Kampala", "Khartoum", "Kigali", "Kinshasa", "Le Caire", "Libreville", "Lilongwe", "Lomé", "Luanda", "Lusaka", "Malabo", "Maputo", "Maseru", "Mbabane", "Mogadiscio", "Monrovia", "Moroni", "N’Djaména", "Nairobi", "Niamey", "Nouakchott", "Ouagadougou", "Port-Louis", "Porto-Novo", "Praia", "Pretoria", "Rabat", "São Tomé", "Tananarive", "Tripoli", "Tunis", "Victoria", "Windhoek", "Yamoussoukro", "Yaoundé" };
            Crea_Quiz(54, CapitalesAfrique, Liste_Capitales_Afrique, LblQuAfriqueCapitales, LblVerifAfriqueCapitales);

            for (int i = 0; i < 54; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnCancelChxCarteAfrique_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = true;
            PnlChxCarteAfrique.Visible = false;
        }

        //Panel Choix Carte Afrique Pays (1850;220)

        private void BtnCancelChxCarteAfriquePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteAfrique.Visible = true;
            PnlChxCarteAfriquePays.Visible = false;
        }

        //Panel Choix Carte Afrique Capitales (1850;240)

        private void BtnCancelChxCarteAfriqueCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteAfrique.Visible = true;
            PnlChxCarteAfriqueCapitales.Visible = false;
        }

        //Panel Choix Carte Asie (1850;260)

        private void BtnChxCarteAsiePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteAsiePays.Location = new Point(0, 0);
            PnlChxCarteAsiePays.Visible = true;
            PnlChxCarteAsie.Visible = false;

            string[] Liste_Pays_Asie = { "Afghanistan", "Arabie saoudite", "Arménie", "Azerbaïdjan", "Bahreïn", "Bangladesh", "Bhoutan", "Birmanie", "Brunei", "Cambodge", "Chine", "Corée du Nord", "Corée du Sud", "Émirats arabes unis", "Géorgie", "Inde", "Indonésie", "Irak", "Iran", "Israël", "Japon", "Jordanie", "Kazakhstan", "Kirghizistan", "Koweït", "Laos", "Liban", "Malaisie", "Maldives", "Mongolie", "Népal", "Oman", "Ouzbékistan", "Pakistan", "Philippines", "Qatar", "Russie", "Singapour", "Sri Lanka", "Syrie", "Tadjikistan", "Taïwan", "Thaïlande", "Timor oriental", "Turkménistan", "Turquie", "Viêt Nam", "Yémen" };
            Crea_Quiz(48, PaysAsie, Liste_Pays_Asie, LblQuAsiePays, LblVerifAsiePays);

            for (int i = 0; i < 48; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnChxCarteAsieCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteAsieCapitales.Location = new Point(0, 0);
            PnlChxCarteAsieCapitales.Visible = true;
            PnlChxCarteAsie.Visible = false;

            string[] Liste_Capitales_Asie = { "Abu Dabi", "Achgabat", "Amman", "Ankara", "Bagdad", "Bakou", "Bandar Seri Begawan", "Bangkok", "Beyrouth", "Bichkek", "Dacca", "Damas", "Dili", "Doha", "Douchanbé", "Erevan", "Hanoï", "Islamabad", "Jakarta", "Jérusalem", "Kaboul", "Katmandou", "Koweït", "Kuala Lumpur", "Malé", "Manama", "Manille", "Mascate", "Naypyidaw", "New Delhi", "Noursoultan", "Oulan-Bator", "Pékin", "Phnom Penh", "Pyongyang", "Riyad", "Sanaa", "Séoul", "Singapour", "Sri Jayawardenapura Kotte", "Tachkent", "Taipei", "Tbilissi", "Téhéran", "Thimphou", "Tokyo", "Vientiane" };
            Crea_Quiz(47, CapitalesAsie, Liste_Capitales_Asie, LblQuAsieCapitales, LblVerifAsieCapitales);

            for (int i = 0; i < 47; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnCancelChxCarteAsie_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = true;
            PnlChxCarteAsie.Visible = false;
        }

        //Panel Choix Carte Asie Pays (1850;280)

        private void BtnCancelChxCarteAsiePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteAsie.Visible = true;
            PnlChxCarteAsiePays.Visible = false;
        }

        //Panel Choix Carte Asie Capitales (1850;300)

        private void BtnCancelChxCarteAsieCapitales_Click(object sender, EventArgs e)
        {
            PnlChxCarteAsie.Visible = true;
            PnlChxCarteAsieCapitales.Visible = false;
        }

        //Panel Choix Carte Océanie (1850;320)

        private void BtnChxCarteOcéaniePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteOcéaniePays.Location = new Point(0, 0);
            PnlChxCarteOcéaniePays.Visible = true;
            PnlChxCarteOcéanie.Visible = false;

            string[] Liste_Pays_Océanie = { "Australie", "Fidji", "Kiribati", "Marshall", "Micronesie", "Nouvelle Zelande", "Palaos", "Papouasie Nouvelle Guinee", "Salomon", "Samoa", "Tonga", "Tuvalu", "Vanuatu" };
            Crea_Quiz(13, PaysOceanie, Liste_Pays_Océanie, LblQuOceaniePays, LblVerifOceaniePays);

            for (int i = 0; i < 13; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnChxCarteOcéanieVilles_Click(object sender, EventArgs e)
        {
            PnlChxCarteOcéanieVilles.Location = new Point(0, 0);
            PnlChxCarteOcéanieVilles.Visible = true;
            PnlChxCarteOcéanie.Visible = false;

            string[] Liste_Capitales_Océanie = { "Apia", "Canberra", "Funafuti", "Honiara", "Majuro", "Ngerulmud", "Nuku Alofa", "Palikir", "Port Moresby", "Port Vila", "Suva", "Tarawa Sud", "Wellington", "Yaren" };
            Crea_Quiz(14, CapitalesOceanie, Liste_Capitales_Océanie, LblQuOceanieCapitales, LblVerifOceanieCapitales);

            for (int i = 0; i < 14; i++)
            {
                Elements_Geo[i].MouseClick += new System.Windows.Forms.MouseEventHandler(Check_Answer);
            }
        }

        private void BtnCancelChxCarteOcéanie_Click(object sender, EventArgs e)
        {
            PnlChxCarte.Visible = true;
            PnlChxCarteOcéanie.Visible = false;
        }

        //Panel Choix Carte Océanie Pays (1850;340)

        private void BtnCancelChxCarteOcéaniePays_Click(object sender, EventArgs e)
        {
            PnlChxCarteOcéanie.Visible = true;
            PnlChxCarteOcéaniePays.Visible = false;
        }

        //Panel Choix Carte Océanie Villes (1850;360)

        private void BtnCancelChxCarteOcéanieVilles_Click(object sender, EventArgs e)
        {
            PnlChxCarteOcéanie.Visible = true;
            PnlChxCarteOcéanieVilles.Visible = false;
        }
    }
}