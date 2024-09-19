MyDictionary
MyDictionary, 
C# kullanarak oluşturduğum basit bir generic sözlük yapısıdır. Bu proje, iki farklı türde (T1, T2) anahtar-değer çiftlerini depolayabilen dinamik bir liste yapısı sunar.
Proje, C# generic'lerinin nasıl kullanılacağını ve dizi büyütme mantığını anlamak için örnek bir çalışmadır.

Özellikler
İki generic tür (T1, T2) ile anahtar-değer ilişkisi depolar.
Dinamik olarak boyutlandırılabilen diziler kullanılarak öğeler eklenir.
Anahtar ve değerlerin dizileri alınarak ekrana yazdırılabilir.
Basit bir Add metodu ile anahtar-değer çifti ekleyebilirsiniz.
GetKeys ve GetValues metodları ile tüm anahtarları ve değerleri alabilirsiniz.

Kullanım
1-Projeyi çalıştırdıktan sonra MyList<int, string> gibi bir generic yapı oluşturabilirsiniz.
2-Add metodu ile listeye anahtar-değer çifti ekleyebilirsiniz.
3-Eklenen değerler GetKeys ve GetValues metodları ile alınabilir ve ekrana yazdırılabilir.


EN

MyDictionary
MyDictionary is a simple generic dictionary structure I created using C#. This project provides a dynamic list structure that can store key-value pairs of two different types (T1, T2). It is an example project to understand how C# generics and array resizing work.

Features
Stores key-value pairs with two generic types (T1, T2).
Dynamically resizes arrays to accommodate new items.
Allows retrieving keys and values as arrays to print or process.
Simple Add method to insert key-value pairs.
GetKeys and GetValues methods to retrieve all keys and values.

Usage
1-After running the project, you can create a generic structure like MyList<int, string>.
2-Use the Add method to add key-value pairs to the list.
3-Retrieve added keys and values with the GetKeys and GetValues methods, and display them as needed.
