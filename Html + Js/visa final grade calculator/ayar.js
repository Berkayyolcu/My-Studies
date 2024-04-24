  function hesapla() {
    var voran = document.getElementById("voran").value;
    var foran = document.getElementById("foran").value;
    var vize = document.getElementById("vize").value;
    var final = document.getElementById("final").value;
    var point = (vize*voran)+(final*foran);

    const x = String(point).slice(0, 3);
    const num = Number(x); 

    document.getElementById("sonuc").value=num;







  }
