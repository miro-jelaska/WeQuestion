/// <binding BeforeBuild='default' Clean='clean' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    react = require("gulp-react"),
    addsrc = require("gulp-add-src");
    
var paths = {
    webroot: "./wwwroot/"
};

paths.js = paths.webroot + "app/**/*.js";
paths.jsx = paths.webroot + "app/**/*.jsx";
paths.css = paths.webroot + "css/**/*.css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatAppDest = paths.webroot + "dist/app.js";
paths.concatMinAppDest = paths.webroot + "dist/app.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";

gulp.task("clean:dist", function (cb) {
    rimraf("./wwwroot/dist", cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("app", function () {
    return gulp.src([paths.jsx], { base: "./dist/" })
        .pipe(react())
        .pipe(addsrc(paths.js))
        .pipe(concat(paths.concatAppDest))
        .pipe(gulp.dest("."));
});

gulp.task("min:app", function () {
    return gulp.src([paths.js], { base: "./dist/" })
        .pipe(react())
        .pipe(addsrc(paths.js))
        .pipe(concat(paths.concatMinAppDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("default", ["clean:dist", "app", "min:app", "min:css"]);
