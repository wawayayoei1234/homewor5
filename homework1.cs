public class homewark : IHomework05
    {
        public static string[] led = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        public string DisplayLEDOnScreen(string ledNo)
        {   
            string sum = null;
            if(ledNo=="A")
            {
            led[9] = led[9]=="[ ]"?"[!]":"[ ]";
            }
            else
            {
               int numled = int.Parse(ledNo);
                numled--;
                led[numled]=led[numled]=="[ ]"?"[!]":"[ ]";
            }
            foreach (string item in led)
            sum+=item;
            return sum;   
        }
    }   