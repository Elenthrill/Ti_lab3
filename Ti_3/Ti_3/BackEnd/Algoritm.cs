using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_3.BackEnd
{
    static class Algoritm
    {
        //static TextBox hEdit6;
        //static TextBox hEdit7;
        //static TextBox hEdit1;
       public static List<long>? PervRoots;

        // Нахождение простых множителей числа
        private static List<long> FindPrimeFactors(long n)
        {
            List<long> factors = new List<long>();
            for (long i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    while (n % i == 0)
                        n /= i;
                }
            }
            if (n != 1)
            {
                factors.Add(n);
            }
            return factors;
        }

        // Умножение с модулем
        private static long Mul(long a, long b, long m)
        {
            if (b == 1)
                return a;
            if (b % 2 == 0)
            {
                long t = Mul(a, b / 2, m);
                return (2 * t) % m;
            }
            return (Mul(a, b - 1, m) + a) % m;
        }

        // Быстрое возведение в степень по модулю
        private static long Pows(long a, long b, long m)
        {
            if (b == 0)
                return 1;
            if (b % 2 == 0)
            {
                long t = Pows(a, b / 2, m);
                return Mul(t, t, m) % m;
            }
            return Mul(Pows(a, b - 1, m), a, m) % m;
        }

        // Нахождение НОД алгоритмом Евклида
        private static long Gcd(long a, long b)
        {
            if (b == 0)
                return a;
            return Gcd(b, a % b);
        }

        // Проверка числа на простоту (тест Ферма)
        private static bool Ferma(long x)
        {
            if (x == 2)
                return true;
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 100; i++)
            {
                long a = (rand.Next() % (x - 2)) + 2;
                if (Gcd(a, x) != 1)
                    return false;
                if (Pows(a, x - 1, x) != 1)
                    return false;
            }
            return true;
        }

        // Быстрое возведение в степень по модулю (альтернативная реализация)
        private static int FastExp(long a, long z, long n)
        {
            long a1 = a;
            long z1 = z;
            long x = 1;
            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 /= 2;
                    a1 = (a1 * a1) % n;
                }
                z1--;
                x = (x * a1) % n;
            }
            return (int)x;
        }

        // Поиск первообразных корней
        public static List<long> FindRoots(long p)
        {
            List<long> simple = FindPrimeFactors(p - 1);
            List<long> res = new List<long>();
            StringBuilder s = new StringBuilder();
            bool flag;
            for (long g = 2; g < p; g++)
            {
                flag = true;
                for (int j = 0; j < simple.Count; j++)
                {
                    if (FastExp(g, (p - 1) / simple[j], p) == 1) flag = false;
                    else
                    {
                        if ((j == simple.Count - 1) && (flag))
                        {
                            res.Add((int)g);
                            s.Append(g.ToString() + "\r\n");
                        }
                    }
                }
            }
            return res;
        }

        // Проверка числа p
        public static long CheckP(string s)
        {
            long res;
            if (!long.TryParse(s, out res))
                return 0;

            if (res > 255)
            {
                if (Ferma(res)) return res;
            }
            return 0;
        }

        // Проверка числа k
        public static long CheckK(string s, long p)
        {
            long res;
            if (!long.TryParse(s, out res))
                return 0;

            if (res > 1)
            {
                if (res < p - 1)
                {
                    if (Gcd(res, p) == 1) return res;
                }
            }
            return 0;
        }

        // Проверка числа x
        public static long CheckX(string s, long p)
        {
            long res;
            if (!long.TryParse(s, out res))
                return 0;

            if (res > 1)
            {
                if (res < p - 1)
                {
                    return res;
                }
            }
            return 0;
        }

        // Проверка первообразного корня g
        public static long CheckG(string s)
        {
            long res;
            if (!long.TryParse(s, out res))
            {
                return 0;
            }

            if (PervRoots.Contains(res))
            {
                return res;
            }
            return 0;
        }

        // Шифрование
        public static string Cipher(long g, long x, long p, long k, string name)
        {
            long y, a, b;
            byte byteRead;
            string cipherName;
            StringBuilder ex = new StringBuilder();
            //string ex = "";

            y = FastExp(g, x, p);
            a = FastExp(g, k, p);

            try
            {
                using (FileStream inFile = new FileStream(name, FileMode.Open, FileAccess.Read))
                using (StreamWriter outFile = new StreamWriter(name + "(cipher).txt"))
                {
                    int byteInt;
                    while ((byteInt = inFile.ReadByte()) != -1)
                    {
                        byteRead = (byte)byteInt;
                        b = (FastExp(y, k, p) * (byteRead % p)) % p;
                        ex.Append(a.ToString() + ' ' + b.ToString() + ' ' + "\r\n");// += a.ToString() + ' ' + b.ToString() + ' ' + "\r\n";
                        outFile.Write(a + " " + b + " ");
                    }
                    return ex.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid file input", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            
        }

        // Дешифрование
        public static string Decipher(long p, long x,string name)
        {
            long y, m;
            int a, b;
            string decipherName;
            StringBuilder s = new StringBuilder();
            try
            {
                using (StreamReader inFile = new StreamReader(name))
                using (FileStream outFile = new FileStream(name.Replace("(cipher)", "(decipher)"), FileMode.Create))
                {
                    string[] numbers;
                    string line;
                    while ((line = inFile.ReadLine()) != null)
                    {
                        numbers = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < numbers.Length; i += 2)
                        {
                            if (i + 1 >= numbers.Length) break;

                            a = int.Parse(numbers[i]);
                            b = int.Parse(numbers[i + 1]);

                            m = (FastExp(a, (int)(x * (p - 2)), (int)p) * (b % p)) % p;
                            outFile.WriteByte((byte)m);
                            s.Append(m.ToString() + "  " + (char)m + "\r\n");

                        }

                    }
                    return s.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error during deciphering", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
