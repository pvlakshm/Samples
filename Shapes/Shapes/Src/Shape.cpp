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

//double Shape::getArea() const
//{
//    return 0.0;
//}