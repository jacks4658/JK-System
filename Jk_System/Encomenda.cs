using System;
using System.Collections;
using System.Linq;

namespace COMPLETE_FLAT_UI
{
    public class Encomenda
    {

        public string ID { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string desc2 { get; set; }
        public string image { get; set; }
        public string url { get; set; }



        Random rnd = new Random();

        public Encomenda()
        {

            this.ID = randomString();
        }

        String randomString()
        {

            const string chars = "ABCDEFGHIJLMNOPQRSTUVXYZ";
            string x = new string(Enumerable.Repeat(chars, 4).Select(s => s[rnd.Next(s.Length)]).ToArray());
            const string nums = "123456789";
            string y= new string    (Enumerable.Repeat(nums,4).Select(s => s[rnd.Next(s.Length)]).ToArray());

            return y + x;
        }


    }
}