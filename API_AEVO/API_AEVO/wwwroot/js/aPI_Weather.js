function PesquisaCurrent(_query, _dvresp, _dvloading) {
    _dvresp.fadeOut(500);
    _dvloading.html("<div class='alert alert-light text-center' role='alert'><img src='../img/loading.gif' /> Pesquisando...</div>");
    _dvresp.html("");
    _dvresp.removeClass();
    var _url = '/Weather/GetCurrent';

    $.ajax({
        url: _url,
        type: 'GET',
        data: {
            query: _query
        },
        processData: true,
        contentType: true,
        success: function (obj) {
            _dvloading.html("");

            if (obj.status) {
                var jobj = JSON.parse(obj.resposta.result);

                if (jobj.error != undefined) {

                    _dvresp.addClass("alert alert-warning");

                    _dvresp.html(jobj.error.info);
                }
                else {
                    //Usar para ver retorno do JSON
                    //console.log(jobj);

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Current</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.current, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Location</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.location, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Request</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.request, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.addClass("alert alert-success");


                }
            }
            else {
                _dvresp.addClass("alert alert-warning");
                _dvresp.html(obj.resposta);
            }

            $("#dvresp").fadeIn(300);

        }
        ,
        error: function (jqXHR) {

        },
        complete: function (jqXHR, status) {

        }

    });
}


function PesquisaForescat(_query, _dvresp, _dvloading) {
    _dvresp.fadeOut(500);
    _dvloading.html("<div class='alert alert-light text-center' role='alert'><img src='../img/loading.gif' /> Pesquisando...</div>");
    _dvresp.html("");
    _dvresp.removeClass();
    var _url = '/Weather/GetForescat';

    $.ajax({
        url: _url,
        type: 'GET',
        data: {
            query: _query
        },
        processData: true,
        contentType: true,
        success: function (obj) {
            _dvloading.html("");

            if (obj.status) {
                var jobj = JSON.parse(obj.resposta.result);

                if (jobj.error != undefined) {

                    _dvresp.addClass("alert alert-warning");

                    _dvresp.html(jobj.error.info);
                }
                else {
                    //Usar para ver retorno do JSON
                    console.log(jobj);

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Current</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.current, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Forescat</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.forescat, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Location</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.location, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.append("<hr>");
                    _dvresp.append("<h4>Request</h4>");
                    _dvresp.append("<hr>");
                    $.each(jobj.request, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });

                    _dvresp.addClass("alert alert-success");

                }
            }
            else {
                _dvresp.addClass("alert alert-warning");
                _dvresp.html(obj.resposta);
            }

            $("#dvresp").fadeIn(300);

        }
        ,
        error: function (jqXHR) {

        },
        complete: function (jqXHR, status) {

        }

    });
}

function PesquisaAutocomplete(_query, _dvresp, _dvloading) {
    _dvresp.fadeOut(500);
    _dvloading.html("<div class='alert alert-light text-center' role='alert'><img src='../img/loading.gif' /> Pesquisando...</div>");
    _dvresp.html("");
    _dvresp.removeClass();
    var _url = '/Weather/GetAutocomplete';

    $.ajax({
        url: _url,
        type: 'GET',
        data: {
            query: _query
        },
        processData: true,
        contentType: true,
        success: function (obj) {
            _dvloading.html("");

            if (obj.status) {
                var jobj = JSON.parse(obj.resposta.result);

                if (jobj.error != undefined) {

                    _dvresp.addClass("alert alert-warning");

                    _dvresp.html(jobj.error.info);
                }
                else {
                    //Usar para ver retorno do JSON
                    //console.log(jobj);
                   

                    $.each(jobj.location, function (key, item) {
                        _dvresp.append("<p>" + key + " : " + item + "</p>");
                    });
                    _dvresp.addClass("alert alert-success");

                }
            }
            else {
                _dvresp.addClass("alert alert-warning");
                _dvresp.html(obj.resposta);
            }

            $("#dvresp").fadeIn(300);

        }
        ,
        error: function (jqXHR) {

        },
        complete: function (jqXHR, status) {

        }

    });
}