
/*querySelectorAll() yöntemi, belgede belirtilen bir
 CSS seçiciyle eşleşen tüm öğeleri statik bir NodeList 
 nesnesi olarak döndürür. NodeList nesnesi düğümlerin bir 
 koleksiyonunu temsil eder. Düğümlere dizin
 numaraları erişilebilir. Endeks 0'dan başlar.*/
 const toggles = document.querySelectorAll('.faq-toggle')

 toggles.forEach((toggle) => {

 	/*JavaScript addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında olduğu gibi,
 	belirli bir olay gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır.*/
 	toggle.addEventListener('click', () => {
 		
 		//toggle : Bir sınıfa geçiş yapar.
 		/*classList : bir elementin sitil sınıflarını tutan bir nesnedir ve 
 		bu nesnenin add metodu ile elemente yeni sınıflar eklenebilir. add metodu 
 		parametre olarak eklenecek sitil sınıfının adını alır.*/
 		toggle.parentNode.classList.toggle('active')
 	})
 })