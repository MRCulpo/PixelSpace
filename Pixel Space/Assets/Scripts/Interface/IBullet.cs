using System.Collections;
public interface IBullet
{
    void checkEnds();
    void move();
    void bulletSpecial();
    IEnumerator bulletCoroutine();
}