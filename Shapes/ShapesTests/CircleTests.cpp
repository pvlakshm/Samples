#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

#include "Circle.h"

namespace ShapesTests
{
    TEST_CLASS(CircleTests)
    {
    public:
        TEST_METHOD(CircleWith0RadiusHas0Area)
        {
            Circle c(0.0);
            double area = c.getArea();
            Assert::AreEqual(0.0, area, DBL_EPSILON);
        }

        TEST_METHOD(CircleWithNegativeRadiusHas0Area)
        {
            Circle c = Circle::Circle(-1.0);
            double area = c.getArea();
            Assert::AreEqual(0.0, area, DBL_EPSILON);
        }

        TEST_METHOD(CircleWithRadius5HasArea78)
        {
            Circle c = Circle::Circle(5.0);
            double area = c.getArea();
            Assert::AreEqual(78.5398, area, 0.1);
        }

        TEST_METHOD(CircleWithRadius100HasArea31415)
        {
            Circle c = Circle::Circle(100.0);
            double area = c.getArea();
            Assert::AreEqual(31415.9, area, 0.1);
        }

        TEST_METHOD(CircleWithRadius1HasArea3point1415)
        {
            Circle c = Circle::Circle(1.0);
            double area = c.getArea();
            Assert::AreEqual(3.14159, area, 0.1);
        }

        TEST_METHOD(GetArea1000TimesGivesSameValue)
        {
            Circle c = Circle::Circle(100.0);

            for (int i = 0; i < 1000; i++)
            {
                double area1 = c.getArea();
                double area2 = c.getArea();

                Assert::AreEqual(area1, area2, DBL_EPSILON);
            }
        }

        TEST_METHOD(GetAreaDoesNotChangeRadius)
        {
            Circle c = Circle::Circle(100.0);

            double area1 = c.getArea();
            double rad = c.getRadius();

            Assert::AreEqual(100.0, rad, 0.01);
        }

        TEST_METHOD(DefaultCicrleIsGreenInColor)
        {
            Circle c = Circle::Circle(0);

            string color = c.getColor();

            Assert::IsTrue(color.compare("green") == 0);
        }
    };
}