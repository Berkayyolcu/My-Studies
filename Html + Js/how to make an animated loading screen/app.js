

/*QuerySelector () yöntemi, CSS seçicilere dayalı olarak DOM'dan html
  elemanlarını seçmenize izin veren iki modern JavaScript yönteminden biridir.
  Bu yöntem ile hem css class'larını hem de id'lerini kullanabilirsiniz.*/
  const loadText = document.querySelector('.loading-text')
  const bg = document.querySelector('.bg')

  let load = 0

/*setInterval Javascript ile belirli aralıklar ile aynı işlemi
  yapmak için geliştirilmiş bir metotdur. Süre milisaniye olarak
  belirtilir ve belirtilen süre beklendikten sonra istenen kod çalıştırılır.*/
  let int = setInterval(bluring, 30)

  function bluring() {
  	load++

//Javascript setInterval fonksiyonunu durdurmak için clearInterval() şeklinde çağırmanız gerekmekte.
if (load > 99) {
	clearInterval(int)
}
  //console.log(load)

  loadText.innerText = `${load}%`
  loadText.style.opacity = scale(load, 0, 100, 1, 0)
  bg.style.filter = `blur(${scale(load, 0, 100, 30, 0)}px)`
}

function scale(number, inMin, inMax, outMin, outMax) {
	return ((number - inMin) * (outMax - outMin)) / (inMax - inMin) + outMin
}




