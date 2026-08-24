function JSPrintAll() {
    window.print();
}
function JSPrintPlanning() {
    window.print();
}

function JSBackPreviousPage() {
    window.history.back();
}

function JSAlert() {
    alert("Hello");
}

function JSGeneratePDF() {
    const element = document.getElementById("element-toexportpdf") || document.getElementById("element-toexportpdf");
    var opt = {
        margin: 1,
        filename: 'programme.pdf',
        image: { type: 'jpeg', quality: 1.0 },
        html2canvas: { dpi: 75, scale: 2, letterRendering: true },
        pagebreak: { mode: ['avoid-all', 'css', 'legacy'] },
        jsPDF: { unit: 'cm', format: 'a4', orientation: 'portrait' }
    };
    html2pdf()
        .set(opt)
        .from(element)
        .toPdf().get('pdf').then((pdf) => {
            var totalPages = pdf.internal.getNumberOfPages();

            for (let i = 1; i <= totalPages; i++) {
                // set footer to every page
                pdf.setPage(i);
                pdf.setFontSize(8);
                pdf.setTextColor(150);
                pdf.text("IGFORMATION  - ZAE CAHORS SUD - 46230 FONTANES - Tel : 05.65.53.62.06 - contact@igformation.fr", pdf.internal.pageSize.getWidth() - 17, pdf.internal.pageSize.getHeight() - 1);
            }
        })
        .save();
}

function JSGeneratePlanningPDF() {
    const element = document.getElementById("element-toexportpdf") || document.getElementById("element-toexportpdf");
    var opt = {
        margin: 1,
        filename: 'calendrier.pdf',
        image: { type: 'jpeg', quality: 1.0 },
        html2canvas: { dpi: 75, scale: 2, letterRendering: true },
        pagebreak: { mode: ['avoid-all', 'css', 'legacy'] },
        jsPDF: { unit: 'cm', format: 'a4', orientation: 'portrait' }
    };
    html2pdf()
        .set(opt)
        .from(element)
        .toPdf().get('pdf').then((pdf) => {
            var totalPages = pdf.internal.getNumberOfPages();

            for (let i = 1; i <= totalPages; i++) {
                // set footer to every page
                pdf.setPage(i);
                pdf.setFontSize(8);
                pdf.setTextColor(150);
                pdf.text("IGFORMATION  - ZAE CAHORS SUD - 46230 FONTANES - Tel : 05.65.53.62.06 - contact@igformation.fr", pdf.internal.pageSize.getWidth() - 17, pdf.internal.pageSize.getHeight() - 1);
            }
        })
        .save();
}