function printContent(element, dotnetHelper) {
    var printWindow = window.open('', '_blank');
    printWindow.document.write(element.innerHTML);
    printWindow.document.close();
    printWindow.focus();
    printWindow.print();
    printWindow.close();
    
    // 清理对Blazor对象的引用，如果需要的话
    dotnetHelper.dispose();
}
