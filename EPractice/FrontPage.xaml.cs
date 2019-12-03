using EPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EPractice
{
    /// <summary>
    /// Interaction logic for FrontPage.xaml
    /// </summary>
    public partial class FrontPage : Page
    {
        NavigationService nav;
        Singleton store = Singleton.Instance;
        public FrontPage()
        {
            this.ShowsNavigationUI = false;
            InitializeComponent();
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            nav = NavigationService.GetNavigationService(this);
            store.SelectedIndex = subjects.SelectedIndex;
            nav.Navigate(new System.Uri("ChapterP.xaml", UriKind.RelativeOrAbsolute),subjects.SelectedIndex);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (!store.alreadySet)
            {
                List<Chapter> c = new List<Chapter>()
            {
                new Chapter("Vector",new List<string>(){"Synopsis/Vector/synopsis.jpg", "Synopsis/Vector/synopsis1.jpg", "Synopsis/Vector/synopsis2.jpg", "Synopsis/Vector/synopsis3.jpg", "Synopsis/Vector/v4.jpg", "Synopsis/Vector/v5.jpg", "Synopsis/Vector/v6.jpg"}),
                new Chapter("Units, Dimension and Measurement",new List<string>(){  "Synopsis/Udm/udm1.jpg", "Synopsis/Udm/udm2.jpg", "Synopsis/Udm/udm3.jpg", "Synopsis/Udm/udm4.jpg", "Synopsis/Udm/udm5.jpg", "Synopsis/Udm/udm6.jpg", "Synopsis/Udm/udm7.jpg", "Synopsis/Udm/udm8.jpg", "Synopsis/Udm/udm9.jpg"}),
                new Chapter("Motion in One Dimension",new List<string>(){}),
                new Chapter("Motion in Two Dimension",new List<string>(){}),
                new Chapter("Newton's Laws of Motion",new List<string>(){"Synopsis/Newtons/newton1.jpg","Synopsis/Newtons/newton2.jpg","Synopsis/Newtons/newton3.jpg","Synopsis/Newtons/newton4.jpg","Synopsis/Newtons/newton5.jpg","Synopsis/Newtons/newton6.jpg","Synopsis/Newtons/newton7.jpg","Synopsis/Newtons/newton8.jpg","Synopsis/Newtons/newton9.jpg","Synopsis/Newtons/newton10.jpg","Synopsis/Newtons/newton11.jpg","Synopsis/Newtons/newton12.jpg","Synopsis/Newtons/newton13.jpg","Synopsis/Newtons/newton14.jpg","Synopsis/Newtons/newton15.jpg","Synopsis/Newtons/newton16.jpg"}),
                new Chapter("Friction",new List<string>(){"Synopsis/Friction/friction1.jpg","Synopsis/Friction/friction2.jpg","Synopsis/Friction/friction3.jpg","Synopsis/Friction/friction4.jpg","Synopsis/Friction/friction5.jpg","Synopsis/Friction/friction6.jpg","Synopsis/Friction/friction7.jpg","Synopsis/Friction/friction8.jpg","Synopsis/Friction/friction9.jpg"}),
                new Chapter("Work,Energy,Power and Collision",new List<string>(){"Synopsis/WorkEnergyPower/work158.jpg","Synopsis/WorkEnergyPower/work159.jpg","Synopsis/WorkEnergyPower/work160.jpg","Synopsis/WorkEnergyPower/work161.jpg","Synopsis/WorkEnergyPower/work162.jpg","Synopsis/WorkEnergyPower/work163.jpg","Synopsis/WorkEnergyPower/work164.jpg","Synopsis/WorkEnergyPower/work165.jpg","Synopsis/WorkEnergyPower/work166.jpg","Synopsis/WorkEnergyPower/work167.jpg","Synopsis/WorkEnergyPower/work168.jpg","Synopsis/WorkEnergyPower/work169.jpg","Synopsis/WorkEnergyPower/work170.jpg","Synopsis/WorkEnergyPower/work171.jpg","Synopsis/WorkEnergyPower/work172.jpg","Synopsis/WorkEnergyPower/work173.jpg","Synopsis/WorkEnergyPower/work174.jpg","Synopsis/WorkEnergyPower/work175.jpg","Synopsis/WorkEnergyPower/work176.jpg"}),
                new Chapter("Rotational Motion",new List<string>(){"Synopsis/Rm/rm229.jpg","Synopsis/Rm/rm230.jpg","Synopsis/Rm/rm231.jpg","Synopsis/Rm/rm232.jpg","Synopsis/Rm/rm233.jpg","Synopsis/Rm/rm234.jpg","Synopsis/Rm/rm235.jpg","Synopsis/Rm/rm236.jpg","/Synopsis/Rm/rm237.jpg","Synopsis/Rm/rm238.jpg","Synopsis/Rm/rm239.jpg","Synopsis/Rm/rm240.jpg","Synopsis/Rm/rm241.jpg","Synopsis/Rm/rm242.jpg","Synopsis/Rm/rm243.jpg","Synopsis/Rm/rm244.jpg","Synopsis/Rm/rm245.jpg","Synopsis/Rm/rm246.jpg","Synopsis/Rm/rm247.jpg"}),
                new Chapter("Gravitation",new List<string>(){"Synopsis/Gravitation/gravitation306.jpg","Synopsis/Gravitation/gravitation307.jpg","Synopsis/Gravitation/gravitation308.jpg","Synopsis/Gravitation/gravitation309.jpg","Synopsis/Gravitation/gravitation310.jpg","Synopsis/Gravitation/gravitation311.jpg","Synopsis/Gravitation/gravitation312.jpg","Synopsis/Gravitation/gravitation313.jpg","Synopsis/Gravitation/gravitation314.jpg","Synopsis/Gravitation/gravitation315.jpg","Synopsis/Gravitation/gravitation316.jpg","Synopsis/Gravitation/gravitation317.jpg","Synopsis/Gravitation/gravitation318.jpg","Synopsis/Gravitation/gravitation319.jpg" }),
                new Chapter("Elasticity",new List<string>(){"Synopsis/Elasticity/elasticity364.jpg","Synopsis/Elasticity/elasticity365.jpg","Synopsis/Elasticity/elasticity366.jpg","Synopsis/Elasticity/elasticity367.jpg","Synopsis/Elasticity/elasticity368.jpg","Synopsis/Elasticity/elasticity369.jpg","Synopsis/Elasticity/elasticity370.jpg","Synopsis/Elasticity/elasticity371.jpg","Synopsis/Elasticity/elasticity372.jpg","Synopsis/Elasticity/elasticity373.jpg","Synopsis/Elasticity/elasticity374.jpg"}),
                new Chapter("Surface Tension",new List<string>(){"Synopsis/SurfaceTension/surface399.jpg","Synopsis/SurfaceTension/surface400.jpg","Synopsis/SurfaceTension/surface401.jpg","Synopsis/SurfaceTension/surface402.jpg","Synopsis/SurfaceTension/surface403.jpg","Synopsis/SurfaceTension/surface404.jpg","Synopsis/SurfaceTension/surface405.jpg","Synopsis/SurfaceTension/surface406.jpg","Synopsis/SurfaceTension/surface407.jpg","Synopsis/SurfaceTension/surface408.jpg"}),
                new Chapter("Fluid Mechanics",new List<string>(){"Synopsis/FluidMechanics/fluid428.jpg","Synopsis/FluidMechanics/fluid429.jpg","Synopsis/FluidMechanics/fluid430.jpg","Synopsis/FluidMechanics/fluid431.jpg","Synopsis/FluidMechanics/fluid432.jpg","Synopsis/FluidMechanics/fluid433.jpg","Synopsis/FluidMechanics/fluid434.jpg","Synopsis/FluidMechanics/fluid435.jpg","Synopsis/FluidMechanics/fluid436.jpg","Synopsis/FluidMechanics/fluid437.jpg","Synopsis/FluidMechanics/fluid438.jpg"}),
                new Chapter("Thermometry,Thermal Expansion and Calorimetry",new List<string>(){"Synopsis/Thermometry/thermometry471.jpg","Synopsis/Thermometry/thermometry472.jpg","Synopsis/Thermometry/thermometry473.jpg","Synopsis/Thermometry/thermometry474.jpg","Synopsis/Thermometry/thermometry475.jpg","Synopsis/Thermometry/thermometry476.jpg","Synopsis/Thermometry/thermometry477.jpg","Synopsis/Thermometry/thermometry478.jpg","Synopsis/Thermometry/thermometry479.jpg","Synopsis/Thermometry/thermometry480.jpg","Synopsis/Thermometry/thermometry481.jpg","Synopsis/Thermometry/thermometry482.jpg"}),
                new Chapter("Kinetic Theory of Gases",new List<string>(){"Synopsis/KinecticTheory/kinectic510.jpg","Synopsis/KinecticTheory/kinectic511.jpg","Synopsis/KinecticTheory/kinectic512.jpg","Synopsis/KinecticTheory/kinectic513.jpg","Synopsis/KinecticTheory/kinectic514.jpg","Synopsis/KinecticTheory/kinectic515.jpg","Synopsis/KinecticTheory/kinectic516.jpg","Synopsis/KinecticTheory/kinectic517.jpg","Synopsis/KinecticTheory/kinectic518.jpg"}),
                new Chapter("Thermodynamics",new List<string>(){"Synopsis/Thermodynamics/thermodynamics563.jpg","Synopsis/Thermodynamics/thermodynamics564.jpg","Synopsis/Thermodynamics/thermodynamics565.jpg","Synopsis/Thermodynamics/thermodynamics566.jpg","Synopsis/Thermodynamics/thermodynamics567.jpg","Synopsis/Thermodynamics/thermodynamics568.jpg","Synopsis/Thermodynamics/thermodynamics569.jpg","Synopsis/Thermodynamics/thermodynamics570.jpg","Synopsis/Thermodynamics/thermodynamics571.jpg","Synopsis/Thermodynamics/thermodynamics572.jpg","Synopsis/Thermodynamics/thermodynamics573.jpg"}),
                new Chapter("Transmission of Heat",new List<string>(){"Synopsis/TransmissionHeat/trans618.jpg","Synopsis/TransmissionHeat/trans619.jpg","Synopsis/TransmissionHeat/trans620.jpg","Synopsis/TransmissionHeat/trans621.jpg","Synopsis/TransmissionHeat/trans622.jpg","Synopsis/TransmissionHeat/trans623.jpg","Synopsis/TransmissionHeat/trans624.jpg","Synopsis/TransmissionHeat/trans625.jpg","Synopsis/TransmissionHeat/trans626.jpg","Synopsis/TransmissionHeat/trans627.jpg","Synopsis/TransmissionHeat/trans628.jpg"}),
                new Chapter("Simple Harmonic Motion",new List<string>(){"Synopsis/SimpleHarmonic/simple671.jpg","Synopsis/SimpleHarmonic/simple672.jpg","Synopsis/SimpleHarmonic/simple673.jpg","Synopsis/SimpleHarmonic/simple674.jpg","Synopsis/SimpleHarmonic/simple675.jpg","Synopsis/SimpleHarmonic/simple676.jpg","Synopsis/SimpleHarmonic/simple677.jpg","Synopsis/SimpleHarmonic/simple678.jpg","Synopsis/SimpleHarmonic/simple679.jpg","Synopsis/SimpleHarmonic/simple680.jpg","Synopsis/SimpleHarmonic/simple681.jpg","Synopsis/SimpleHarmonic/simple682.jpg"}),
                new Chapter("Waves and Sound",new List<string>(){"Synopsis/Waves/waves741.jpg","Synopsis/Waves/waves742.jpg","Synopsis/Waves/waves743.jpg","Synopsis/Waves/waves744.jpg","Synopsis/Waves/waves745.jpg","Synopsis/Waves/waves746.jpg","Synopsis/Waves/waves747.jpg","Synopsis/Waves/waves748.jpg","Synopsis/Waves/waves749.jpg","Synopsis/Waves/waves750.jpg","Synopsis/Waves/waves751.jpg","Synopsis/Waves/waves752.jpg","Synopsis/Waves/waves753.jpg","Synopsis/Waves/waves754.jpg","Synopsis/Waves/waves755.jpg","Synopsis/Waves/waves756.jpg","Synopsis/Waves/waves757.jpg","Synopsis/Waves/waves758.jpg","Synopsis/Waves/waves759.jpg","Synopsis/Waves/waves760.jpg","Synopsis/Waves/waves761.jpg","Synopsis/Waves/waves762.jpg"}),
                new Chapter("Electrostatics",new List<string>(){"Synopsis/Electrostatics/electrostatic5.jpg","Synopsis/Electrostatics/electrostatic6.jpg","Synopsis/Electrostatics/electrostatic7.jpg","Synopsis/Electrostatics/electrostatic8.jpg","Synopsis/Electrostatics/electrostatic9.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg","Synopsis/Electrostatics/electrostatic10.jpg"}),
                new Chapter("Current Electricity",new List<string>(){}),
                new Chapter("Heating and Chemical Effect of Current",new List<string>(){}),
                new Chapter("Magnetic Effect of Current",new List<string>(){}),
                new Chapter("Magnetism",new List<string>(){}),
                new Chapter("Electromagnetic Induction",new List<string>(){}),
                new Chapter("Alternating Current",new List<string>(){}),
                new Chapter("Electron,Photon,Photo-electric Effect and X-Rays",new List<string>(){}),
                new Chapter("Atomic and Nuclear Physics",new List<string>(){}),
                new Chapter("Electronics",new List<string>(){}),
                new Chapter("Communication",new List<string>(){}),
                new Chapter("Ray Optics",new List<string>(){}),
                new Chapter("Wave Optics",new List<string>(){}),
                new Chapter("Universe",new List<string>(){})
            };
                Subject s = new Subject()
                {
                    Name = "Physics",
                    chapter = c
                };
                store.subjects.Add(s);
                store.alreadySet = true;
            }
            
            subjects.ItemsSource = store.subjects;
        }
    }
}
