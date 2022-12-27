//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace conditionalstatementexercises
//{
//    internal class task11
//    {
//        public void solution()
//        {

//            console.writeline("\n\n");
//            console.writeline("calculate root of quadratic equation :\n");
//            console.writeline("----------------------------------------");
//            console.writeline("\n\n");

//            console.writeline("input the value of a : ");
//            int a = convert.toint32(console.readline());
//            console.writeline("input the value of b : ");
//            int b = convert.toint32(console.readline());
//            console.writeline("input the value of c : ");
//            int c = convert.toint32(console.readline());

//            double d = b * b - 4 * a * c;
//            if (d == 0)
//            {
//                console.writeline("both roots are equal.\n");
//                double x1 = -b / (2.0 * a);
//                double x2 = x1;
//                console.writeline("first  root root1= {0}\n", x1);
//                console.writeline("second root root2= {0}\n", x2);
//            }
//            else if (d > 0)
//            {
//                console.writeline("both roots are real and diff-2\n");

//                x1 = (-b + math.sqrt(d)) / (2 * a);
//                x2 = (-b - math.sqrt(d)) / (2 * a);

//                console.writeline("first  root root1= {0}\n", x1);
//                console.writeline("second root root2= {0}\n", x2);
//            }
//            else
//                console.writeline("root are imeainary;\nno solution. \n\n");
//        }

//    }
//}
