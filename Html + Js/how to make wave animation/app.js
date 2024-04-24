
/*querySelectorAll() yöntemi, belgede belirtilen 
bir CSS seçiciyle eşleşen tüm öğeleri statik 
bir NodeList nesnesi olarak döndürür.
NodeList nesnesi düğümlerin bir koleksiyonunu temsil eder.
Düğümlere dizin numaraları erişilebilir.*/
const labels = document.querySelectorAll('.form-control label')

labels.forEach((label) => {

/*innerHTML : JavaScript ile Html DOM üzerindeki bir öğenin içeriğini
 Html kodları ile birlikte alabilir veya seçtiğimiz Html 
 öğesinin içerisine Html kodları ekleyebiliriz.
 Bunun için JavaScript'deki innerHtml özelliğini kullanıyoruz.*/
 label.innerHTML = label.innerText

 /*Split : Elimizde bulunan metini istediğimiz 
 şekilde parçalara bölerek ondan bir array 
 oluşturan JavaScript String metodudur.*/
 .split('')

 /*Map anahtar ve değer ikilisini tutan ve değerlerin 
 eklenme sırasını hatırlayan bir JavaScript nesnesidir.*/
 .map(
 	(letter, index) =>
 	`<span style="transition-delay:${index * 50}ms">${letter}</span>`
 	)

 .join('')
})