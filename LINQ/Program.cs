
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding the data source
            int[] marks = { 45, 56, 63, 41, 54, 36, 87, 78, 96 };

            //Defining the query expression
            IEnumerable<int> qResult = 
                from mark in marks
                where mark > 70
                orderby mark ascending
                select mark;

            IEnumerable<int> ans = marks.Where(mark => mark > 70);
            foreach (int i in qResult)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("Count -> " + qResult.Count());



            Console.WriteLine();
            Console.WriteLine("ans");
            foreach (int i in ans)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("Average -> " + ans.Average());
            

            // object Query groupBy
            Console.WriteLine("\nGroupBY query");
            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];

            foreach (var item in queryFoodGroups)
            {
                Console.WriteLine( "Key - " +  item.Key + "\nValue :");
                foreach (string item1 in item)
                {
                    Console.WriteLine( "\t" +  item1);
                }
            }

            


             Student.QueryHighScores(1, 90);

            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };



            var myQuery1 = Student.QueryMethod1(nums);


            // Query myQuery1 is executed in the following foreach loop.
            Console.WriteLine("Results of executing myQuery1:");
            // Rest the mouse pointer over myQuery1 to see its type.
            foreach (var s in myQuery1)
            {
                Console.WriteLine(s);
            }
            // You also can execute the query returned from QueryMethod1
            // directly, without using myQuery1.
            Console.WriteLine("\nResults of executing myQuery1 directly:");
            // Rest the mouse pointer over the call to QueryMethod1 to see its
            // return type.
            foreach (var s in Student.QueryMethod1(nums))
            {
                Console.WriteLine(s);
            }

            Student.QueryMethod2(nums, out IEnumerable<string> myQuery2);

            // Execute the returned query.
            Console.WriteLine("\nResults of executing myQuery2:");
            foreach (var s in myQuery2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}