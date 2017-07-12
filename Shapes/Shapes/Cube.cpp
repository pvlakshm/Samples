#include "Cube.h"

Cube::Cube(int side, const string & color)
    : Shape(color), side(side) { }

int Cube::getSide() const
{
    return side;
}

void Cube::setSide(int side)
{
    this->side = side;
}

double Cube::getVolume() const
{
    return side * side * side;
}