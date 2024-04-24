/*QuerySelector () yöntemi, CSS seçicilere dayalı olarak 
DOM'dan html elemanlarını seçmenize izin veren iki modern 
JavaScript yönteminden biridir. Bu yöntem ile hem css 
class'larını hem de id'lerini kullanabilirsiniz.*/
const left = document.querySelector('.left')
const right = document.querySelector('.right')
const container = document.querySelector('.container')

/*addEventListener yöntemi, bir kullanıcı bir 
 düğmeyi tıkladığında olduğu gibi, belirli bir olay
 gerçekleştiğinde çağrılacak işlevleri
 ayarlamanıza olanak tanır.*/
 left.addEventListener('mouseenter', () => {
 	container.classList.add('hover-left')
 })
 left.addEventListener('mouseleave', () => {
 	container.classList.remove('hover-left')
 })

 right.addEventListener('mouseenter', () => {
 	container.classList.add('hover-right')
 })

 right.addEventListener('mouseleave', () => {
 	container.classList.remove('hover-right')
 })



