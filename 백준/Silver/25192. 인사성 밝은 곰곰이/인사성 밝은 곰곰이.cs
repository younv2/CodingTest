/*
 [채팅을 치는 유저들은 새로운 유저가 들어올 때만 곰곰티콘을 사용, 그 이후는 일반 채팅]
 - HashSet을 이용하여 새로운 유저가 들어오기 전까지의 채팅을 중복으로 치는 유저를 제한함.
 - ENTER가 들어오면 해당 HashSet안의 갯수를 total에 더해주고 초기화
 - 마지막 값이 들어오면 HashSet안의 Count를 total에 더해줌
 */ 
public class Program
{
    static void Main(string[] args)
    {
        HashSet<string> strings = new HashSet<string>();
        int total = 0;
        int count = int.Parse(Console.ReadLine());
        string enter = "ENTER";
        for(int i = 0; i < count; i++)
        {
            string chatUser = Console.ReadLine();
            if (chatUser.Equals(enter))
            {
                
                total += strings.Count;
                strings.Clear();
                continue;
            }
            strings.Add(chatUser);

            if(i == count -1)
                total += strings.Count;
        }

        Console.WriteLine(total);
    }
}