
/*querySelector() yöntemi, belgede belirtilen bir CSS seçiciyle eşleşen ilk öğeyi döndürür. 
Not: querySelector() yöntemi yalnızca belirtilen seçicilerle eşleşen ilk öğeyi döndürür.
Tüm eşleşenleri geri getirmek için bunun yerine querySelectorAll() yöntemini kullanın.*/
const counters = document.querySelectorAll('.counter')

counters.forEach((counter) => {
  counter.innerHTML = '0'

  const updateCounter = () => {
    const target = Number(counter.getAttribute('data-target'))
    //console.log(typeof target, target)

/* innerText, : <script> ve <style> öğeleri hariç tüm Html öğelerinin metin içeriğini döndürürken
 textContent tüm Html öğelerinin metin içeriğini döndürür. 2 – innerText, Css ile gizlenen
 Html öğelerinin metnini döndürmez fakat textContent döndürür.*/
 const c = +counter.innerText

 console.log(c);

 const increment = target / 300
/*setTimeout fonksiyonu belirli bir zaman sonra çalıştırmaya yarar. 
setInterval fonksiyonun belirli aralıklar ile sürekli çalışmasını sağlar.*/
if (c < target ) {
  counter.innerText = `${Math.ceil(c + increment)}`
  setTimeout(updateCounter,1)
} else {
  counter.innerText = target
}
}

updateCounter()
})