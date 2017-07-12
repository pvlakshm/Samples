#include "Shape.h"

Shape::Shape(const string & color)
{
    this->color = color;
}

string Shape::getColor() const
{
    return color;
}

void Shape::setColor(const string & color)
{
    this->color = color;
}
