using System.Text;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //string title = "Clean code";
            //title = title.ToUpper();
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);

            #endregion

            #region Question 2
            string title = "Clean code";
            string title2 = "Clean code";
            bool areSame = ReferenceEquals(title, title2);
            Console.WriteLine(areSame);

            #endregion

            #region Question03
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.Append("Book List");
            //    sb.Append(" - Updated");
            //    Console.WriteLine(sb.ToString());
            //}
            #endregion
        }
    }
}
