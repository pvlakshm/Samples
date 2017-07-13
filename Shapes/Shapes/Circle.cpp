#include "Circle.h"

#define PI 3.14159265
// ctors
Circle::Circle(double radius, const string & color)
    : Shape(color), radius(radius > 0.01 ? radius : 0.0) { }

double Circle::getRadius() const
{
    return radius;
}

void Circle::setRadius(double radius)
{
    this->radius = radius;
}

double Circle::getArea() const
{
    return PI * radius * radius;
}

double Circle::getVolume() const
{
    return 0;
}