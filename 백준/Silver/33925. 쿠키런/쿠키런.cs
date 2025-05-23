
/*
[입력값]
    첫번째 - 장애물 개수 / 최대 점프 횟수 / 최대 슬라이드 횟수 / 최대 체력 / 한대 맞았을때의 데미지
    두번째 ~ 네번째 -> 장애물

[출력값]
    남은 체력(스테이지 클리어 못할 시 -1 출력)

[1]
    처음에는 맵의 1번 인덱스 부터 v와 ^의 갯수를 세어서 데미지를 주려고 했으나, 
    HighJump의 경우 두번을 뛰어야 하지만 주는 데미지는 1번만 준다는 것을 확인.
    그래서 ObstacleType이라는 enum값을 만들고 각 배열이 어떤 장애물 타입인지 받아 해당 부분을 해결함.
[2]
    해당 횟수를 이용해서 스테이지에서 최대한 체력을 적게 써야한다는 것을 깨달았다.
    그러면 점프와 낮은 점프가 몇개가 있는지 확인을 하고 최대한 낮은 점프에서 먼저 남은 점프 횟수를 활용해야 한다.
    장애물 enum을 만들어서 하는것은 지금 불필요하다고 판단하고 정리.
 */
public class Program
{
    static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int obstacleCnt = inputs[0];
        int canJumpCnt = inputs[1];
        int canSlideCnt = inputs[2];
        int health = inputs[3];
        int damage = inputs[4];

        char[][] map = new char[3][];

        int totaldamage = 0;

        int slideCnt = 0;
        int highjumpCnt = 0;
        int jumpCnt = 0;

        for (int i = 0; i < 3; i++)
            map[i] = Console.ReadLine().ToCharArray();


        for(int i = 0; i < map[0].Length; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (map[j][i] == 'v')
                {
                    slideCnt++;
                    break;
                }
                if (map[j][i] == '^')
                {
                    _ = j == 1 ? highjumpCnt += 1 : jumpCnt += 1;
                    break;
                }
            }
        }
        totaldamage += Math.Max(slideCnt - canSlideCnt, 0) * damage;
        totaldamage += Math.Max(jumpCnt - canJumpCnt, 0) * damage;
        canJumpCnt = Math.Max(canJumpCnt - jumpCnt, 0);
        totaldamage += Math.Max(highjumpCnt - canJumpCnt/2, 0) * damage; 


        health = health - totaldamage;
        if (health <= 0)
            health = -1;

        Console.WriteLine(health);
    }
}