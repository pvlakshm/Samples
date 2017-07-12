#include "Cuboid.h"

Cuboid::Cuboid(int length, int width, int height, const string & color)
    : Shape(color), length(length), width(width), height(height) { }

int Cuboid::getLength() const
{
    return length;
}

void Cuboid::setLength(int length)
{
    this->length = length;
}

int Cuboid::getWidth() const
{
    return width;
}

void Cuboid::setWidth(int width)
{
    this->width = width;
}

int Cuboid::getHeight() const
{
    return height;
}

void Cuboid::setHeight(int height)
{
    this->height = height;
}

double Cuboid::getVolume() const
{
    return length * width * height;
}