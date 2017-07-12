#include "Triangle.h"

Triangle::Triangle(int base, int height, const string & color)
    : Shape(color), base(base), height(height) { }

int Triangle::getBase() const
{
    return base;
}

void Triangle::setBase(int base)
{
    this->base = base;
}

int Triangle::getHeight() const
{
    return height;
}

void Triangle::setHeight(int height)
{
    this->height = height;
}

double Triangle::getArea() const
{
    return 0.5 * base * height;
}