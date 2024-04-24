
/*querySelectorAll() yöntemi, belgede belirtilen
tüm elementlerine ulaşıp, değiştirebilirsiniz.*/

const panels = document.querySelectorAll(".panel");

panels.forEach(panel => {

	/* addEventListener : Bir kullanıcı bir düğmeyi tıkladığında olduğu gibi, belirli bir
	olay gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır.*/
	panel.addEventListener("click", () => {

		/*removeActive : asağıdaki fonksiyonu burada
		  cağırmak icin bir isim belirliyoruz*/
		removeActive();

        /*classList : Bir elementin stil sınıflarını tutan bir nesnedir ve
         bu nesnenin add metodu ile elemente yeni sınıflar eklenebilir.
         add metodu parametre olarak eklenecek stil sınıfının adını alır.*/
         panel.classList.add("active");
     });

})

//Buradaki fonksiyonu yukarıda cağrıyoruz
function removeActive(){
	panels.forEach(panel => {
    	/* remove : JavaScript ile Html DOM üzerindeki bir veya
    	daha fazla öğeyi Html belgesinden kaldırabiliriz.*/
    	panel.classList.remove("active");
    })
}