using System;

namespace OhjelmoijanPaiva.Tree
{
    /// <summary>
    /// Choise is class displayed for player when travelling the decision tree.
    /// </summary>
    class Choise
    {
        private string text;        
        

        public Choise(string text)
        {
            this.text = text;
        }

        public void Print()
        {
            Console.WriteLine(this.text);
        }
    }
}
