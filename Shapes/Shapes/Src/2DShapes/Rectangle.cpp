#include "Rectangle.h"

Rectangle::Rectangle(int length, int width, const string & color)
    : Shape(color), length(length), width(width) { }

int Rectangle::getLength() const
{
    return length;
}

void Rectangle::setLength(int length)
{
    this->length = length;
}

int Rectangle::getWidth() const
{
    return width;
}

void Rectangle::setWidth(int width)
{
    this->width = width;
}

double Rectangle::getArea() const
{
    return length * width;
}