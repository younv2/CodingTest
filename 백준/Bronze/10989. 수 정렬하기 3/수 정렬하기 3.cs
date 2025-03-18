class Program
    {
        static void Main(string[] args)
        {
            using var reader = new System.IO.StreamReader(Console.OpenStandardInput());
            using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
            
            // 1) 입력으로부터 정수의 개수(count)를 읽어온다.
            int count = Convert.ToInt32(reader.ReadLine());
            
            // 2) 0부터 10000까지의 숫자를 카운팅하기 위해 길이가 10001인 배열을 준비한다.
            int[] list = new int[10001];

            // 3) count 번 만큼 정수를 읽어와, 해당 정수에 해당하는 인덱스를 1씩 증가시킨다.
            for (int i = 0; i < count; i++)
            {
                list[int.Parse(reader.ReadLine())]++;
            }

            // 4) 0부터 10000까지 순회하면서,
            //    해당 인덱스에 기록된 개수(list[i])만큼 그 인덱스(숫자)를 출력한다.
            for (int i = 0; i <= 10000; i++)
            {
                if (list[i] != 0)
                {
                    for (int j = 0; j < list[i]; j++)
                    {
                        print.WriteLine(i);
                    }
                }
            }
        }
    }