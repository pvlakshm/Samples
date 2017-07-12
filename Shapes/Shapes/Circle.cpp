#include "Circle.h"

#define PI 3.14159265

Circle::Circle(int radius, const string & color)
    : Shape(color), radius(radius) { }

int Circle::getRadius() const
{
    return radius;
}

void Circle::setRadius(int radius)
{
    this->radius = radius;
}

double Circle::getArea() const
{
    return PI * radius * radius;
}