

public interface IPlayerController
{
    float move { get; }
    void Moving(float _move);
    
}
public interface IRange
{
    void Shoot(string damage);
}
public interface IMelee
{
    void Sli(string damage);
}
public interface IWeapon
{
    string damage { get; }
}
