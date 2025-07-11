
double GetPrice(double p, double d)
{
    double r = p * (1 - d);
    r = r * 1.05;
    return r;
}
