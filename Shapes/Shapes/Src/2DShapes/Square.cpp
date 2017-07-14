#include "Square.h"

// Constructor
Square::Square(int side, const string & color)
    : Shape(color), side(side) { }

int Square::getSide() const
{
    return side;
}

void Square::setSide(int side)
{
    this->side = side;
}

double Square::getArea() const
{
    return side * side;
}