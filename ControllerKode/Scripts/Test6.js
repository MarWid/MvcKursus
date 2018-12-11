console.log("Hej");

var knap = jQuery("#minKnap"); // Samme som var knap = $("#minKnap");
console.log(knap);

knap.click(function () {

   // console.log("Et eller andet"); // For at skrive console.log tast cl+Tab+Tab

    //$.getJSON("/Home/Test5").done(function (data) {
    //    console.log(data);

        $.getJSON("/Home/Test5").done(function (data) {
            var ol = $("#minListe");
            ol.empty();
            for (var i = 0; i < data.length; i++) {
                var li = $("<li />").html(data[i].Navn);
                ol.append(li);
            }

    });

})

