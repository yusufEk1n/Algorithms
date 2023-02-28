## Öklid Algoritması

İki A ve B tam sayısının Ortak Bölenlerinin En Büyüğünün GCD(Greatest common divisor), **A ve B'yi bölen en büyük tam sayı** olduğunu hatırlayalım.

### Algoritma

GCD(A,B)'nin bulunması için Öklid Algoritması şu şekildedir:
- Eğer A=0 ise, GCD(0,B)=B olacağı için GCD(A,B)=B olur ve   bu noktada durabiliriz. 
- Eğer B=0 ise, GCD(A,0)=A olacağı için GCD(A,B)=A olur ve bu noktada durabiliriz. 
- A sayısını bölüm ve kalan formunda yazın (A=B⋅Q+R)
- GCD(A,B)=GCD(B,R) olduğu için, GCD(B,R)'yi Öklid Algoritmasını kullanarak bulun.

## Örnek:

270 ve 192'nin GCD'sini bulun
- A=270, B=192
- A ≠0
- B ≠0
- Bölme yapılarak, bölüm 270/192 = 1 ve kalan 78 olarak bulunur. Bu işlemi 270 = 192 * 1 +78 şeklinde de yazabiliriz.

GCD(270,192)=GCD(192,78) olduğu için GCD(192,78)'i bulun
- A=192, B=78
- A ≠0
- B ≠0
- Bölme yapılarak, bölüm 192/78 = 2 ve kalan 36 olarak bulunur. Bu işlemi 192 = 78 * 2 + 36 şeklinde de yazabiliriz.

GCD(192,78)=GCD(78,36) olduğu için, GCD(78,36)'yı bulun
- A=78, B=36
- A ≠0
- B ≠0
- Bölme yapılarak, bölüm 78/36 = 2 ve kalan 6 olarak bulunur.
Bu işlemi 78 = 36 * 2 + 6 şeklinde de yazabiliriz.

GCD(78,36)=GCD(36,6) olduğu için, GCD(36,6)'yı bulun
- A=36, B=6
- A ≠0
- B ≠0
- Bölme yapılarak, bölüm 36/6 = 6 ve kalan 0 olarak bulunur.
  Bu işemi 36 = 6 * 6 + 0 şeklinde de yazabiliriz.

GCD(36,6)=GCD(6,0) olduğu için, GCD(6,0)'yı bulun
- A=6, B=0
- A ≠0
- B =0, 
- **GCD(6,0)=6**

Böylece şunu göstermiş olduk:

GCD(270,192) = GCD(192,78) = GCD(78,36) = GCD(36,6) = GCD(6,0) = 6
**GCD(270,192) = 6**

## Sözde Kod (Pseudo code):

```
function gcd(a, b)
      if a < b:
        a, b = b, a
      if a % b == 0:
        return b
      else
        return gcd(b, a % b)
```

## Zaman Karmaşıklığı (Time complexity):

Algoritmanın ilk birkaç adımını düşünelim.
- İlk adımda **a > b** şeklinde bir **(a, b)** ikilisi ele alalım.
- Sonraki adım **(b,c)** ve **c = a mod b** olur.
- İkinci adımdan sonraki iki sayı **(c, d)** ve **d = b mod c** olur. 

Bu noktadan sonra geriye doğru gidelim.
- **d = b mod c** ifadesini(bölme kurallarından) **b = kc + d** ve **k > 0** formatında yazabiliriz.
- **k = 1** olarak alırsak, **b** sayısı daima **c + d** toplamından büyük veya eşit olacaktır. Öyleyse **b >= 1c + d = c + d** *(1)* ifadesini yazabiliriz.
- En başta *a > b* ifadesi yerine **a > c + d** *(2)* yazarsak ve *(1)* ifadesi ile *(2)* ifadesini alt alta toplarsak, **(a + b) > 2(c + d)** sonucunu elde ederiz.

-- Adımları devam ettirirsek, ilk adımdan sonraki her iki adımda girdi değerlerinin toplamının iki katı, iki adım önceki girdi değerlerinin toplamından daha az olduğunu görürüz. 

**Sonuc**: Daha fazla uzatmadan bu şekilde taranacak bölgenin sürekli yarı yarıya azaldığı algoritmalar *O(log(n))* karmaşıklığına sahiptir. Bizim algoritmamızın karmaşıklığı **O(log(a + b))**