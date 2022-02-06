using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_Odev2
{
    //Bu sınıfı açma sebebimiz Classlar ile Database arasındaki köprüyü kurmak.
    //DbContext ile inheritence ederek bu yol açılmış olur
    //Nuget pazarından entityframework'u aktif et
    public class NorthwindContext:DbContext
    {

    }
}
