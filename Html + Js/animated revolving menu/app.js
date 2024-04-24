
/*getElementById Metodu Web sayfasındaki html 
etiketlerine ulaşmak için kullanılır.*/
const open = document.getElementById('open')
const close = document.getElementById('close')

/*QuerySelector () yöntemi, CSS seçicilere dayalı olarak DOM'dan html
elemanlarını seçmenize izin veren iki modern JavaScript yönteminden biridir.  */
const container = document.querySelector('.container')

/* addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında 
olduğu gibi, belirli bir olay gerçekleştiğinde çağrılacak 
işlevleri ayarlamanıza olanak tanır.*/
open.addEventListener('click', () => {
	container.classList.add('show-nav')
})

/*classList bir elementin stil sınıflarını tutan bir nesnedir 
ve bu nesnenin add metodu ile elemente yeni sınıflar eklenebilir.*/
close.addEventListener('click', () => {
	container.classList.remove('show-nav')
})