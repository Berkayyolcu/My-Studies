/*querySelectorAll() yöntemi, belgede belirtilen bir CSS seçiciyle 
eşleşen tüm öğeleri statik bir NodeList nesnesi olarak döndürür.*/
const boxes = document.querySelectorAll('.box')

/*addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında olduğu 
gibi, belirli bir olay gerçekleştiğinde çağrılacak işlevleri 
ayarlamanıza olanak tanır. Olaylar, kullanıcı veya tarayıcı bir
sayfayı manipüle ettiğinde gerçekleşen eylemlerdir.*/
window.addEventListener('scroll', checkBoxes)

checkBoxes()

function checkBoxes() {
  const triggerBottom = (window.innerHeight / 6) * 4
  //console.log((window.innerHeight / 6) * 4)

  boxes.forEach((box) => {
    //getBoundingClientRect()bir öğenin boyutunu ve görünüm alanına göre konumunu döndürür.
    const boxTop = box.getBoundingClientRect().top

    if (boxTop < triggerBottom) {
      /*classList bir elementin sitil sınıflarını tutan bir nesnedir
      ve bu nesnenin add metodu ile elemente yeni sınıflar eklenebilir.*/
      box.classList.add('show')
    } else {
      box.classList.remove('show')
    }
  })
}