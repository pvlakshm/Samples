#include "Sphere.h"

#define PI 3.14159265

Sphere::Sphere(int radius, const string & color)
    : Shape(color), radius(radius) { }

int Sphere::getRadius() const
{
    return radius;
}

void Sphere::setRadius(int radius)
{
    this->radius = radius;
}

double Sphere::getVolume() const
{
    return 4/3 * (PI * radius * radius * radius);
}