#ifndef POSITION_H
#define POSITION_H

class Position {
private:
    double m_x;
    double m_y;
    double m_z;

public:
    Position(double x = 0.0, double y = 0.0, double z = 0.0);

    double getX() const;
    double getY() const;
    double getZ() const;

    Position* MoveX(double dx);
    Position* MoveY(double dy);
    Position* MoveZ(double dz);
};

#endif
