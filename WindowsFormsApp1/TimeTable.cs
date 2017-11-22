using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace WindowsFormsApp1
{
    public partial class TimeTable : Form
    {
         List<weather> list2 = new List<weather>();
         List<route> list5 = new List<route>();

        public Random randomGenerator;
        public Random randomGenerator1;

        public string lala = "μμ";

        List<String> myList = new List<String>();   //Δημιουργία νέας λίστας από Strings
        BindingSource mySource = new BindingSource();

        Bitmap img = Properties.Resources._14;
        Bitmap img2 = Properties.Resources._36;
        Bitmap img3 = Properties.Resources._40;
        Bitmap img4 = Properties.Resources._25;
        Bitmap img5 = Properties.Resources._26;
        Bitmap img6 = Properties.Resources._30;
        Bitmap img7 = Properties.Resources._32;

        public string radio1;
        public string radio2;
        public string radio3;
        public string radio4;
        public TimeTable()
        {
            InitializeComponent();
            mySource.DataSource = myList;  //Το mysource τραβάει τα δεδομένα από τη λίστα
            //listBox1.DataSource = mySource;
        }

        public void create_list()
        {
            //καιρος list
            list2.Add(new weather(1, "10", "Αυξημένη κίνηση στο κέντρο του Πειραιά", "Αρεές νεφώσεις με τοπικές βροχές"));
            list2.Add(new weather(2, "8", "Αυξημένη κυκλοφορία λόγω βροχής", "Καταρακτώδεις βροχές με καταιγίδες"));
            list2.Add(new weather(3, "5", "Κυκλοφορία μόνο με αλυσίδες" ,"Τοπικές χιονοπτώσεις στα ορεινά"));
            list2.Add(new weather(4, "17", "Αυξημένη κίνηση σε Κηφισίας και Πέτρου Ράλλη","Τοπικές νεφώσεις"));
            list2.Add(new weather(5, "24", "Ομάλη κυκλοφορία στους δρόμους" ,"Ηλιοφάνεια με τοπικές νεφώσεις"));
            list2.Add(new weather(6, "30", "Η κυκλοφορία στο κέντρο της Αθήνας είναι ομαλή", "Ηλιοφάνεια"));
            list2.Add(new weather(7, "35", "Τροχαίο στην Αλεξάνδρας - μποτιλιάρισμα","Καύσωνας"));

            

            //list5
            list5.Add(new route("Αυτοκίνητο","Εργασία", "Πηγαίνοντας στην εργασια με το Αυτοκινητό σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας ", "Άφηξη στο Πανεπιστήμιο σε μια ώρα", "Η κοντινότερη θεση για πάρκινγ βρισκεται στα 140 μέτρα από το σημείο που επιλέξατε", "θα πρέπει μα ξεκινησεις τοτε", "Στα 50 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Αυτοκίνητο", "Σχολή", "Πηγαίνοντας στο Πανεπιστήμιο με το Αυτοκινητό σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας, θα διασχίσετε την κηφισίας, θα βγείτε στη Συγγρού θα φτάσετε παλαιό φάληρο και θα διασχίσετε τη γρηγορίου Λαμπαρακη ", "Άφηξη στο Πανεπιστήμιο σε μια ώρα", "Η κοντινότερη θεση για πάρκινγ βρισκεται στα 30 μέτρα από το σημείο που επιλέξατε", "θα πρέπει μα ξεκινησεις τοτε", "Στα 150 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Αυτοκίνητο", "Έξοδος", "Πηγαίνοντας για καφέ με το Αυτοκινητό σας θα διασχίσετε την κηφισίας θα στρίψετε δεξιά στην οδό Πανόρμου και θα φτάσετε στον προορισμό σας ", "Άφηξη στο Πανεπιστήμιο σε μια ώρα", "Η κοντινότερη θεση για πάρκινγ βρισκεται στα 50 μέτρα από το σημείο που επιλέξατε", "θα πρέπει μα ξεκινησεις τοτε", "Στα 200 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Αυτοκίνητο", "Σπίτι", "Πηγαίνοντας στο Σπιτι με το Αυτοκινητό σας θα διασχίσετε την άνοδο της κηφισίας θα κάνετε δεξιά στην οδό Πεντέλης, μετά από 300 μέτρα θα κάνετε αριστερά στην οδό Σαπφούς ", "Άφηξη στο Πανεπιστήμιο σε μια ώρα", "Η κοντινότερη θεση για πάρκινγ βρισκεται στα 10 μέτρα από το σημείο που επιλέξατε", "θα πρέπει μα ξεκινησεις τοτε", "Στα 80 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Πόδια", "Εργασία", "Πηγαίνοντας στην εργασια με τα Πόδια θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας. Φυσικά σας βολεύει καλύτερα να πάρετε λεωφορείο", "Άφηξη στο Πανεπιστήμιο σε μιαμιση ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 70 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Πόδια", "Σχολή", "Πηγαίνοντας στο Πανεπιστήμιο με τα Πόδια θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας, θα διασχίσετε την κηφισίας, θα βγείτε στη Συγγρού θα φτάσετε παλαιό φάληρο και θα διασχίσετε τη γρηγορίου Λαμπαρακη. Φυσικά σας βολεύει καλύτερα να πάρετε λεωφορείο ", "Άφηξη στο Πανεπιστήμιο σε μιαμιση ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 90 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Πόδια", "Έξοδος", "Πηγαίνοντας για καφέ με τα πόδια θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα δυο χιλιόμετρα θα στρίψετε αριστερά για χαλάνδρι. Στο τέλος της οδού Όλγας φτάσατε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε μιαμιση ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 120 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Πόδια", "Σπίτι", "Πηγαίνοντας στο Σπιτι με τα Πόδια θα διασχίσετε την άνοδο της κηφισίας θα κάνετε δεξιά στην οδό Πεντέλης, μετά από 300 μέτρα θα κάνετε αριστερά στην οδό Σαπφούς", "Άφηξη στο Πανεπιστήμιο σε μιαμιση ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 600 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Ποδήλατο", "Εργασία", "Πηγαίνοντας στην εργασια με το Ποδήλατο σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 180 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Ποδήλατο", "Σχολή", "Πηγαίνοντας στο Πανεπιστήμιο με το Ποδήλατο θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας, θα διασχίσετε την κηφισίας, θα βγείτε στη Συγγρού θα φτάσετε παλαιό φάληρο και θα διασχίσετε τη γρηγορίου Λαμπαρακη", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 500 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Ποδήλατο", "Έξοδος", "Πηγαίνοντας για καφέ με το Ποδήλατο θα διασχίσετε την κηφισίας θα στρίψετε δεξιά στην οδό Πανόρμου και θα φτάσετε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 60 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Ποδήλατο", "Σπίτι", "Πηγαίνοντας στο Σπιτι με το Ποδήλατο θα διασχίσετε την άνοδο της κηφισίας θα κάνετε δεξιά στην οδό Πεντέλης, μετά από 300 μέτρα θα κάνετε αριστερά στην οδό Σαπφούς ", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 50 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Τρένο", "Εργασία", "Πηγαίνοντας στην εργασια με τον Ηλεκτρικό θα πάτε μέχρι τον σταθμό του Αμαρουσίου θα πάρετε το τρένο θα κατεβείτε στον σταθμό Αττική και θα πάρετε το μετρό προς κατεύθυνση Αμπελοκήπους ", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 330 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Τρένο", "Σχολή", "Πηγαίνοντας στο Πανεπιστήμιο με τον Ηλεκτρικό θα πάτε μέχρι τον σταθμό του Αμαρουσίου θα πάρετε το τρένο θα κατεβείτε στον σταθμό του Πειραιά και στην συνέχεια θα πάρετε το λεωφορείο 910 με κατεύθυνση τη σχολή σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 160 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Τρένο", "Έξοδος", "Πηγαίνοντας για καφέ με τον Ηλεκτρικό θα πάτε μέχρι τον σταθμό του Αμαρουσίου θα πάρετε το τρένο θα κατεβείτε στον σταθμό της Νερατζιώτισσας θα περπατήσετε λίγα μέτρα για να φτάσετε στο εμπορικό κέντρο Mall", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 600 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Τρένο", "Σπίτι", "Πηγαίνοντας στο Σπιτι με τον Ηλεκτρικό θα επιβιβαστείτε στον σταθμό του νέου Φαλήρου και θα κατέβετε στην σταθμό Αμαρουσίου διασχίζοντας στα 20 μέτρα την οδό Περικλέους φτάνετε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 20 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Λεωφορείο", "Εργασία", "Πηγαίνοντας στην εργασια με το Λεωφορείο θα βγείτε στην οδό Πεντέλης και θα επιβιβαστείτε στο Α8 με κατεύθυνση προς Αθήνα θα κατεβείτε στην στάση ΙΚΑ", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 10 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Λεωφορείο", "Σχολή", "Πηγαίνοντας στο Πανεπιστήμιο με το Λεωφορείο θα βγείτε στην οδό Πεντέλης και θα επιβιβαστείτε στο Α8 με κατεύθυνση προς Αθήνα θα κατεβείτε στην στάση Αμπελοκήπων στην θα πάρετε το Α7 με κατεύθυνση προς Παλαιό Φάληρο θα κατεβείτε στο τέρμα και θα πάρετε το 929 με κατεύθυνση το Πανεπιστήμιο", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 80 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Λεωφορείο", "Έξοδος", "Πηγαίνοντας για καφέ με το Λεωφορείο  θα βγείτε στην οδό Πεντέλης και θα επιβιβαστείτε στο Α8 με κατεύθυνση προς Αθήνα θα κατεβείτε στην στάση Χαλάνδρι στα 100 μέτρα υπάρχουν καφετέριες", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 40 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Λεωφορείο", "Σπίτι", "Πηγαίνοντας στο Σπιτι με το Λεωφορείο θα επιβιβαστείτε στο Α7 με κατέυθυνση προς μαρούσι, θα κατεβείτε στην στάση Αμαρουσίου, και θα πάρετε το Α8 προς Μελίσσια. Κατεβαίνοντας στην 8 στάση φτάνετε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 90 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Συνδιασμός", "Εργασία", "Πηγαίνοντας στην εργασια σας θα περπατήσετε με τα πόδια μέχρι την οδό Πεντέλης θα πάρετε το Α8 κατεβείτε στην κηφισίας θα πάρετε το Α7 και κατεβείτε στην Αλεξάνδρας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 110 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Συνδιασμός", "Σχολή", "Πηγαίνοντας στο Πανεπιστήμιο θα πάρετε το αυτοκίνητό σας θα παρκάρετε στον σταθμό Αμαρουσίου, στη συνέχεια θα πάρετε το τρένο με προορισμό στο παλαιό Φάληρο θα κατεβείτε και διασίζοντας 500 μέτρα φτάνετε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 10 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Συνδιασμός", "Έξοδος", "Πηγαίνοντας για καφέ θα πάρετε το αυτοκίνητό σας θα παρκάρετε στην οδό Ομήρου, στην συνέχεια θα πάρετε το Α5 για να φτάσετε στο κέντρο του χαλανδρίου, στα 50 μέτρα έχετε φτάσει στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 30 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Συνδιασμός", "Σπίτι", "Πηγαίνοντας στο Σπιτι θα επιβιβαστείτε στον σταθμό του νέου Φαλήρου και θα κατέβετε στην σταθμό Αμαρουσίου διασχίζοντας στα 20 μέτρα την οδό Περικλέους φτάνετε στον προορισμό σας", "Άφηξη στο Πανεπιστήμιο σε 2 ώρα", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 50 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Μέσα", "Σπίτι", "Πηγαίνοντας στην εργασια σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας", "Πηγαίνοντας στο Πανεπιστήμιο θα βγείτε στην Αλεξάνδρας θα πάρετε το Α7 θα σταματήσετε στο παλαιό Φάληρο θα περπατήσετε 300 μέτρα και φτάνετε στον προορισμό σας ", "θα βρεις παρκινγ", "θα πρέπει μα ξεκινησεις τοτε", "Στα 40 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Μέσα", "Σπίτι", "Πηγαίνοντας στην εργασια σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας", "Πηγαίνοντας στο Πανεπιστήμιο θα βγείτε στην Αλεξάνδρας θα πάρετε το Α7 θα σταματήσετε στο παλαιό Φάληρο θα περπατήσετε 300 μέτρα και φτάνετε στον προορισμό σας ", "Πηγαίνοντας για καφέ θα διασχίσετε την κηφισίας θα στρίψετε δεξιά στην οδό Πανόρμου και θα φτάσετε στον προορισμό σας", "θα πρέπει να ξεκινησεις τοτε", "Στα 40 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Μέσα", "Σπίτι", "Πηγαίνοντας στην εργασια σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας", "Πηγαίνοντας στο Πανεπιστήμιο θα βγείτε στην Αλεξάνδρας θα πάρετε το Α7 θα σταματήσετε στο παλαιό Φάληρο θα περπατήσετε 300 μέτρα και φτάνετε στον προορισμό σας ", "Πηγαίνοντας για καφέ θα διασχίσετε την κηφισίας θα στρίψετε δεξιά στην οδό Πανόρμου και θα φτάσετε στον προορισμό σας", "Πηγαίνοντας στο Σπιτι θα διασχίσετε την άνοδο της κηφισίας θα κάνετε δεξιά στην οδό Πεντέλης, μετά από 300 μέτρα θα κάνετε αριστερά στην οδό Σαπφούς ", "Στα 40 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));
            list5.Add(new route("Μέσα", "Σπίτι", "Πηγαίνοντας στην εργασια σας θα βγείτε στην οδό Πεντέλης θα την διασχίσετε μέχρι το τέρμα της. Θα κάνετε αριστερά στην κηφισίας και στα πέντε χιλιόμετρα θα στρίψετε δεξιά στην Λεωφόρο Αλεξάνδρας στο δεύτερο στένο θα κάνετε δεξιά και θα φτάσετε στον προορισμό σας", "Πηγαίνοντας στο Πανεπιστήμιο θα βγείτε στην Αλεξάνδρας θα πάρετε το Α7 θα σταματήσετε στο παλαιό Φάληρο θα περπατήσετε 300 μέτρα και φτάνετε στον προορισμό σας ", "Πηγαίνοντας για καφέ θα διασχίσετε την κηφισίας θα στρίψετε δεξιά στην οδό Πανόρμου και θα φτάσετε στον προορισμό σας", "Πηγαίνοντας στο Σπιτι θα διασχίσετε την άνοδο της κηφισίας θα κάνετε δεξιά στην οδό Πεντέλης, μετά από 300 μέτρα θα κάνετε αριστερά στην οδό Σαπφούς ", "Στα 40 μέτρα υπάρχει διαθέσιμο μαγαζί για τον καφέ σας"));



        }

        public void create2()
        {
            foreach (route i in list5)
            {
                if (checkBox2.Checked == true)
                {
                    if (checkBox6.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox6.Text) && (i.getplace().Contains(checkBox2.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {                               
                                richTextBox1.Text = (i.getroute() + " . " + label5.Text + " . " + i.getparking() + " . " + i.getcafe() + " . " + radio2);                                                          

                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " . " + radio2);
                               
                            }

                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox8.Text) && (i.getplace().Contains(checkBox2.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {                                
                                richTextBox1.Text = (i.getroute() + " . " + label5.Text + " . " + " . " + i.getcafe() + radio2);                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " . " + label5.Text + " . " + radio2);                               
                            }

                        }
                    }

                    if (checkBox7.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox7.Text) && (i.getplace().Contains(checkBox2.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " . " + label5.Text + " . "+ " . " + i.getcafe() + radio2);                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + radio2);                              
                            }

                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox5.Text) && (i.getplace().Contains(checkBox2.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " " + i.getcafe() + radio2);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + radio2);                               
                            }

                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox9.Text) && (i.getplace().Contains(checkBox2.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " " + i.getcafe() + radio2);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + radio2);                               
                            }
                        }
                    }
                }



                if (checkBox1.Checked == true)
                {
                    if (checkBox6.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox6.Text) && (i.getplace().Contains(checkBox1.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " " + i.getcafe() + radio1);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " "  + radio1);                                
                            }

                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox8.Text) && (i.getplace().Contains(checkBox1.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio1);                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " "  + radio1);                             
                            }

                        }
                    }
                    if (checkBox7.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox7.Text) && (i.getplace().Contains(checkBox1.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio1);                               
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " "  + radio1);                               
                            }

                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox5.Text) && (i.getplace().Contains(checkBox1.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio1);
                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " "  + radio1);                            
                            }

                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox9.Text) && (i.getplace().Contains(checkBox1.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio1);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " "  + radio1);                               
                            }

                        }
                    }
                }

                if (checkBox3.Checked == true)
                {
                    if (checkBox6.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox6.Text) && (i.getplace().Contains(checkBox3.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " " + i.getcafe() + radio3);                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " "  + radio3);                               
                            }

                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox8.Text) && (i.getplace().Contains(checkBox3.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " " + i.getcafe() + radio3);                               
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " "  + radio3);                               
                            }

                        }
                    }
                    if (checkBox7.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox7.Text) && (i.getplace().Contains(checkBox3.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio3);                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + radio3);                              
                            }

                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox5.Text) && (i.getplace().Contains(checkBox3.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio3);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " "  + radio3);                                
                            }

                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox9.Text) && (i.getplace().Contains(checkBox3.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio3);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " "  + radio3);                              
                            }

                        }
                    }
                }
                if (checkBox4.Checked == true)
                {
                    if (checkBox6.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox6.Text) && (i.getplace().Contains(checkBox4.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " " + i.getcafe() + radio4);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + i.getparking() + " "  + radio4);                                
                            }

                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox8.Text) && (i.getplace().Contains(checkBox4.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio4);                              
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " "  + radio4);                              
                            }

                        }
                    }
                    if (checkBox7.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox7.Text) && (i.getplace().Contains(checkBox4.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " " + i.getcafe() + radio4);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " "  + radio4);                                
                            }

                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox5.Text) && (i.getplace().Contains(checkBox4.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " "  + " " + i.getcafe() + radio4);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " " + radio4);                            
                            }

                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        if (i.getmedia().Contains(checkBox9.Text) && (i.getplace().Contains(checkBox4.Text)))
                        {
                            if (radioButton2.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " " + i.getcafe() + radio4);                                
                            }
                            else if (radioButton1.Checked == true)
                            {
                                richTextBox1.Text = (i.getroute() + " " + label5.Text + " " + " "  + radio4);                                
                            }

                        }
                    }
                }


                if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[24].getroute() + " . " + radio1 + " . " + list5[24].gettime_arr() +" . "+ radio2 + " . " + list5[24].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[24].getroute() + " . " + radio1 + " . " + list5[24].gettime_arr() + " . " + radio2;
                        }

                    }

                }
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[25].getroute() + " . " + radio1 + " . " + list5[25].gettime_arr() + " . " + radio2 + " . " + list5[25].getparking() + " . " + radio3+ " . " + list5[25].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[25].getroute() + " . " + radio1 + " . " + list5[25].gettime_arr() + " . " + radio2 + " . " + list5[25].getparking() + " . " + radio3;
                        }

                    }

                }
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[26].getroute() + " . " + radio1 + " . " + list5[26].gettime_arr() + " . " + radio2 + " . " + list5[26].getparking() + " . " + radio3 + " . " + list5[26].gettime_begin() + " . " + radio4 + " . " +list5[26].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[26].getroute() + " . " + radio1 + " . " + list5[26].gettime_arr() + " . " + radio2 + " . " + list5[26].getparking() + " . " + radio3 + " . " + list5[26].gettime_begin() + " . " + radio4;
                        }

                    }
                }
                if (checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[27].gettime_arr() + " . " + radio2 + " . " + list5[27].getparking() + " . " + radio3 + " . "+ list5[27].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[27].gettime_arr() + " . " + radio2 + " . " + list5[27].getparking() + " . " + radio3;
                        }

                    }

                }
                if (checkBox2.Checked == true && checkBox4.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[27].gettime_arr() + " . " + radio2 + " . " + list5[27].gettime_begin() + " . " + radio4 + " . " + list5[27].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[27].gettime_arr() + " . " + radio2 + " . " + list5[27].gettime_begin() + " . " + radio4;
                        }

                    }
                }
                if (checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[27].getparking() + " . " + radio3 + " . " + list5[27].gettime_begin() + " . " + radio4 + " . " + list5[27].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[27].getparking() + " . " + radio3 + " . " + list5[27].gettime_begin() + " . " + radio4;
                        }

                    }
                }
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox4.Checked == true)
                {
                    if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox5.Checked == true)

                    {
                        if (radioButton2.Checked == true)
                        {
                            richTextBox1.Text = list5[27].getroute() + " . " + radio1 + " . " + list5[27].gettime_arr() + " . " + radio2 + " . "+ list5[27].gettime_begin() + " . " + radio4 + " . " + list5[27].getcafe();
                        }
                        else if (radioButton1.Checked == true)
                        {
                            richTextBox1.Text = list5[27].getroute() + " . " + radio1 + " . " + list5[27].gettime_arr() + " . " + radio2 + " . " + list5[27].gettime_begin() + " . " + radio4;
                        }

                    }
                }



            }
        }

        public void check()
        {
                var checkedRadio1 = new[] { flowLayoutPanel1}
                   .SelectMany(g => g.Controls.OfType<RadioButton>()
                                            .Where(r => r.Checked));

            foreach (var c in checkedRadio1)
            {
                if (radioButton3.Checked==true || radioButton4.Checked== true 
                    || radioButton5.Checked == true || radioButton6.Checked == true 
                    || radioButton7.Checked == true || radioButton8.Checked == true)
                {
                    string hold = c.Text;
                    if (Convert.ToInt32(label1.Text) < Convert.ToInt32(15))
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(2);
                        if (aek < 12)
                        {
                            lala = "πμ";                           
                            radio1 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {                           
                            radio1 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                    else
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(1);
                        if (aek < 12)
                        {
                            lala = "πμ";                           
                            radio1 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {                            
                            radio1 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                }
                             
            }


            var checkedRadio2 = new[] {flowLayoutPanel2}
                  .SelectMany(g => g.Controls.OfType<RadioButton>()
                                           .Where(r => r.Checked));

            foreach (var c in checkedRadio2)
            {
                if (radioButton9.Checked == true || radioButton10.Checked == true 
                    || radioButton11.Checked == true || radioButton12.Checked == true 
                    || radioButton13.Checked == true || radioButton14.Checked == true)
                {
                    string hold = c.Text;
                    if (Convert.ToInt32(label1.Text) < Convert.ToInt32(15))
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(2);
                        if (aek < 12)
                        {
                            lala = "πμ";                         
                            radio2 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {                            
                            radio2 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                    else
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(1);
                        if (aek < 12)
                        {
                            lala = "πμ";                           
                            radio2 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {                           
                            radio2 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                }               
            }

            var checkedRadio3 = new[] { flowLayoutPanel3 }
                  .SelectMany(g => g.Controls.OfType<RadioButton>()
                                           .Where(r => r.Checked));

            foreach (var c in checkedRadio3)
            {
                if (radioButton15.Checked == true || radioButton16.Checked == true 
                    || radioButton17.Checked == true || radioButton18.Checked == true 
                    || radioButton19.Checked == true || radioButton20.Checked == true)
                {
                   string hold = c.Text;
                    if (Convert.ToInt32(label1.Text) < Convert.ToInt32(15))
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(2);
                        if (aek < 12)
                        {
                            lala = "πμ";
                            radio3 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {
                            radio3 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                    else
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(1);
                        if (aek < 12)
                        {
                            lala = "πμ";
                            radio3 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {
                            radio3 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                }
            }

            var checkedRadio4 = new[] { flowLayoutPanel4 }
                 .SelectMany(g => g.Controls.OfType<RadioButton>()
                                          .Where(r => r.Checked));

            foreach (var c in checkedRadio4)
            {
                if (radioButton21.Checked == true || radioButton22.Checked == true 
                    || radioButton23.Checked == true || radioButton24.Checked == true 
                    || radioButton25.Checked == true || radioButton26.Checked == true)
                {
                    string hold = c.Text;
                    if (Convert.ToInt32(label1.Text) < Convert.ToInt32(15))
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(2);
                        if (aek < 12)
                        {
                            lala = "πμ";
                            radio4 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {
                            radio4 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                    else
                    {
                        float aek = Convert.ToSingle(hold) - Convert.ToSingle(1);
                        if (aek < 12)
                        {
                            lala = "πμ";
                            radio4 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                        else
                        {
                            radio4 = " Για να είστε στην ώρα σας θα πρέπει να ξεκινήσετε στις  " + aek.ToString() + " : 00 " + lala;
                        }
                    }
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            clock_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");                    

            create_list();
            randomGenerator1 = new Random();
            int gen = randomGenerator1.Next(1, 8);

            foreach (weather i in list2)
            {
                if (gen.Equals(i.getcode()))
                {
                    label1.Text = i.getdegree();
                    label4.Text = i.getweath();
                    label5.Text = i.gettraffic();
                 
                }
                if (label1.Text.Equals("5"))
                {

                    pictureBox1.Image = img;
                   
                }
                if (label1.Text.Equals("35"))
                {
                    pictureBox1.Image = img2;
                  
                }
                if (label1.Text.Equals("8"))
                {
                    pictureBox1.Image = img3;
                    
                }
                if (label1.Text.Equals("10"))
                {
                    pictureBox1.Image = img4;
                   
                }
                if (label1.Text.Equals("17"))
                {
                    pictureBox1.Image = img5;
                   
                }
                if (label1.Text.Equals("24"))
                {
                    pictureBox1.Image = img6;
                   
                }
                if (label1.Text.Equals("30"))
                {
                    pictureBox1.Image = img7;                  
                }                
            }
        }

        private void clock1(object sender, EventArgs e)
        {
            clock_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            check();
            create2();
            this.timer2.Start();
            bankprogress.Visible = true;
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked)
            {
               
                button3.Visible = true;
                flowLayoutPanel6.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button1.Visible = true;
                flowLayoutPanel5.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button1.Visible = true;
                flowLayoutPanel5.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button1.Visible = true;
                flowLayoutPanel5.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                button1.Visible = true;
                flowLayoutPanel5.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button4.Visible = true;
                flowLayoutPanel7.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Visible = true;
            }
           
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                button2.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bankprogress.Increment(4);
            if (bankprogress.Value == 100)
            {
                button2.Text = "Επιτυχής Αναζήτηση";
                button2.Enabled = false;
                richTextBox1.Visible = true;
                button5.Visible = true;
                this.timer2.Stop();
            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked )
            {
                string message = "Θα θέλατε να προχωρήσετε την παραγγελία του καφέ σας;";
                string caption = "Παραγγελία";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //MessageBox.Show("Η παραγγελία σας καταχωρήθηκε επιτυχώς");
                    Foodstore myForm = new Foodstore();
                    myForm.Show(this);
                    this.Hide();
                    button2.Visible = true;

                }
                else
                {
                    MessageBox.Show("Ανεπιτυχής καταχώρηση παραγγελίας");
                    button2.Visible = true;

                }
            }
         
        }

        public void SaveMyFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.pdf";
            saveFile1.Filter = "(*.pdf)|*.pdf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                PdfWriter.GetInstance(doc, new FileStream(saveFile1.FileName, FileMode.Create));

                //UTF8
                string sylfaenpath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\sylfaen.ttf";
                BaseFont sylfaen = BaseFont.CreateFont(sylfaenpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font head = new iTextSharp.text.Font(sylfaen, 12f);

                doc.Open();              
                doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text, head));
                doc.Close();
        
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }

        
    }
}
