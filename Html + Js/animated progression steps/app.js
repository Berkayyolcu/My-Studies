
//getElementById Metodu : html etiketlerine ulaşmak için kullanılır.
//const ile oluşturulan bir değişkene daha sonrasında tekrar değer ataması yapılamaz.
const progress = document.getElementById("progress");
const circles = document.querySelectorAll(".circle");
const prev = document.getElementById("prev");
const next = document.getElementById("next");

//let ile tanımlanan bir değişkeni tekrar tanımlayamayız ancak değerini güncelleyebiliriz.
let currentActive = 1;

next.addEventListener("click", () => {
	currentActive++;

	if(currentActive > circles.length){
		currentActive = circles.length
	}

	update();
});

prev.addEventListener("click", () => {
	currentActive--;

	if(currentActive < 1){
		currentActive = 1;
	}

	update();
});

function update(){
	circles.forEach((circle, index) => {
		if(index < currentActive){
			circle.classList.add('active');
		} else{
			circle.classList.remove('active');
		}
	})

	/*querySelectorAll() : yöntemi, belgede belirtilen bir CSS seçiciyle eşleşen
	 tüm öğeleri statik bir NodeList nesnesi olarak döndürür. */
	const actives = document.querySelectorAll(".active");

     //console.log(actives.length, circles.length);
     //console.log(actives.length / circles.length);
     //console.log((actives.length / circles.length) *100);
     //console.log((actives.length -1) / (circles.length -1) *100);
     //console.log((actives.length -1) / (circles.length -1) *100 + '%');

     progress.style.width = (actives.length -1) / (circles.length -1) *100 + '%';


     if(currentActive === 1){
     	prev.disabled = true;
     } else if(currentActive === circles.length){
     	next.disabled = true;
     } else{
     	prev.disabled = false;
     	next.disabled = false;
     }
 }



 