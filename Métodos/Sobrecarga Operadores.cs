public static Punto3D operator *(int num, Punto3D p1)
{
    Punto3D p2 = new Punto3D();

    p2.setX(num * p1.getX());
    p2.setY(num * p1.getY());
    p2.setZ(num * p1.getZ());

    return p2;
}
