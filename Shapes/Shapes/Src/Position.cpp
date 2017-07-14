#include "Position.h"

Position::Position(double x, double y, double z)
{
    m_x = x;
    m_y = y;
    m_z = z;
}

double Position::getX() const
{
    return m_x;
}

double Position::getY() const
{
    return m_y;
}

double Position::getZ() const
{
    return m_z;
}

Position* Position::MoveX(double dx)
{
    m_x += dx;
    return this;
}

Position* Position::MoveY(double dy)
{
    m_y += dy;
    return this;
}

Position* Position::MoveZ(double dz)
{
    m_z += dz;
    return this;
}
